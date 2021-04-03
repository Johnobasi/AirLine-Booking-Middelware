using System;
using System.Collections.Generic;
using System.Text;

namespace GreenAfricaAPI.Business.EmailServices
{
    public class EmailService : IEmailService
    {
        private readonly ILogger<EmailService> _logger;
        private readonly IConfiguration _configuration;
        private readonly IOptions<AppSettingsDto> _appSettings;
        private static IDictionary<string, string> _mappings = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) {
            {".jpeg", "image/jpeg"},
            {".jpg", "image/jpeg"},
            {".pdf", "application/pdf"},
            {".png", "image/png"},
            {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"}
        };

        public EmailService(ILogger<EmailService> logger, IConfiguration configuration, IOptions<AppSettingsDto> appSettings)
        {
            _logger = logger;
            _configuration = configuration;
            _appSettings = appSettings;
        }

        public async Task<bool> Send(EmailMessage emailMessage, bool isService = false, string appUrl = null, string name = null, string signature = "Bulk Account Opening Team")
        {
            if (emailMessage.ToAddresses.Any(x => x.Address == null)) return false;


            string filePath = string.Empty;
            if (!isService)
                filePath = "wwwroot\\EmailTemplates";
            else
                filePath = "EmailTemplates";

            StreamReader str = new StreamReader(filePath + "\\Notification.html");
            string Body = str.ReadToEnd().Replace("[Subject]", emailMessage.Subject).Replace("[Todaydate]", string.Format("{0:dd-MM-yyyy}", DateTime.Now));

            var path = filePath;

            string mailSubject = emailMessage.Subject;

            Body = Body.Replace("{todayDate}", DateTime.Now.ToString("dd MMMM yyyy"));
            Body = Body.Replace("{Subject}", emailMessage.Subject);
            Body = Body.Replace("{Name}", FirstCharToUpper(name));
            Body = Body.Replace("{contentOne}", emailMessage.Content);
            Body = Body.Replace("{ContentTwo}", string.Empty);
            str.Close();

            List<Recipient> recipients = new List<Recipient>();
            foreach (var address in emailMessage.ToAddresses)
            {
                Recipient recipient = new Recipient
                {
                    displayName = address.Name,
                    email = address.Address,
                    recipientType = "TO"
                };
                recipients.Add(recipient);
            }
            List<Attachment> attachments1 = new List<Attachment>();
            ////attachments1.Add(GetAttachment(filePath, "stallion.jpg", "stallion"));
            //attachments1.Add(GetAttachment(filePath, "YT.jpg", "youtube"));
            //attachments1.Add(GetAttachment(filePath, "twitter.jpg", "twitter"));
            //attachments1.Add(GetAttachment(filePath, "fb.jpg", "facebook"));
            //attachments1.Add(GetAttachment(filePath, "IG.jpg", "instagram"));

            try
            {
                var token = await GetMailToken();
                if (token == null) { return false; }
                var url = _configuration["AppSettings:MailResource"] + "?access_token=" + token.access_token;

                EmailModel emailModel = new EmailModel
                {
                    sender = new Sender
                    {
                        displayName = _configuration["AppSettings:SenderName"],
                        email = _configuration["AppSettings:SenderEmail"]
                    },
                    recipients = recipients,
                    body = Body,
                    subject = mailSubject,
                    attachments = attachments1,
                    footer = "",
                };
                EmailResponse emailResponse = await SendEmailUsingMiserve(emailModel, url).ConfigureAwait(false);
                if (emailResponse == default(EmailResponse)) { return false; }

                //use retrial method to ensure mail is sent
                int trials = 1;
                while (emailResponse.code == "99")
                {
                    if (trials > 10) { return false; }
                    emailResponse = await SendEmailUsingMiserve(emailModel, url).ConfigureAwait(false);
                    trials++;
                }
                _logger.LogInformation("Email Sent " + emailMessage.ToAddresses[0].ToString());
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace + "  " + ex.Message);
                return false;
            }

        }
        public async Task<bool> SendEmail(EmailRequest emailRequest, string appUrl = null, string name = null, string signature = "Bulk Account Opening Team")
        {
            try
            {
                if (emailRequest.Recepient is null) return false;

                string mailText = string.Empty;
                var buildDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var filePath = buildDir + @"\wwwroot\EmailTemplates\SuccessfulAccountCreation.html";
                using (var streamReader = new StreamReader(filePath))
                {
                    mailText = await streamReader.ReadToEndAsync();
                    streamReader.Close();
                }

                mailText = mailText.Replace("{todayDate}", DateTime.Now.ToString("dd MMMM yyyy"));
                mailText = mailText.Replace("{Subject}", emailRequest.Subject);
                mailText = mailText.Replace("{Name}", FirstCharToUpper(name));
                mailText = mailText.Replace("{tableData}", emailRequest.Message);

                var recipients = new List<Recipient>
                {
                    new Recipient { displayName = emailRequest.Recepient.Name, email = emailRequest.Recepient.Address, recipientType = "TO" }
                };

                var token = await GetMailToken();
                if (token == null) { return false; }
                var url = $"{_appSettings.Value.MailResource}?access_token={token.access_token}";

                EmailModel emailModel = new EmailModel
                {
                    sender = new Sender { email = emailRequest.Sender.Address, displayName = emailRequest.Sender.Name },
                    recipients = recipients,
                    body = mailText,
                    subject = emailRequest.Subject,
                    attachments = null,
                    footer = "",
                };
                EmailResponse emailResponse = await SendEmailUsingMiserve(emailModel, url).ConfigureAwait(false);

                if (emailResponse == default(EmailResponse)) { return false; }

                int trials = 1;
                while (emailResponse.code == "99")
                {
                    if (trials > 10) { return false; }
                    emailResponse = await SendEmailUsingMiserve(emailModel, url).ConfigureAwait(false);
                    trials++;
                }
                _logger.LogInformation("Email Sent " + emailRequest.Recepient.Address.ToString());
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace + "  " + ex.Message);
                return false;
            }

        }

        private async Task<EmailResponse> SendEmailUsingMiserve(EmailModel queryobject, string url, bool byPass = true)
        {
            try
            {
                using (HttpClientHandler handler = new HttpClientHandler())
                {
                    handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                    using (var client = new HttpClient(handler))
                    {
                        client.DefaultRequestHeaders.Accept.Clear();

                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        var json = JsonConvert.SerializeObject(queryobject);

                        _logger.LogInformation($"JSON REQ >> {url} >> {json} >>");

                        var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                        var response = await client.PostAsync(new Uri(url), stringContent).ConfigureAwait(false);

                        if (response.IsSuccessStatusCode)
                        {
                            var responseContent = response.Content.ReadAsStringAsync().Result;

                            var emailResponse = JsonConvert.DeserializeObject<EmailResponse>(responseContent);

                            _logger.LogInformation($"Response Code >> {emailResponse.code} >>");

                            return emailResponse;
                        }

                        var responseErrorContent = response.Content.ReadAsStringAsync().Result;
                        _logger.LogError($" Error Response ::  {responseErrorContent}");

                        return default(EmailResponse);

                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($" Token::  {ex.Message} :: {ex.StackTrace}  :: {ex.Source}");

                return default(EmailResponse);
            }
        }

        private Attachment GetAttachment(string filePath, string fileName, string cid)
        {
            byte[] imageArray = File.ReadAllBytes(filePath + fileName);
            FileInfo fileInfo = new FileInfo(filePath + fileName);
            Attachment attachment = new Attachment
            {
                cid = cid,
                content = Convert.ToBase64String(imageArray),
                inline = true,
                mime = GetMimeType(fileInfo.Extension),
                name = filePath + fileName,
            };

            return attachment;
        }

        public static string GetMimeType(string extension)
        {
            if (extension == null) { throw new ArgumentNullException("extension"); }
            if (!extension.StartsWith(".")) { extension = "." + extension; }
            string mime;
            return _mappings.TryGetValue(extension, out mime) ? mime : "application/octet-stream";
        }

        public async Task<AccessToken> GetMailToken()
        {
            string response = string.Empty;

            try

            {
                using (HttpClientHandler handler = new HttpClientHandler())
                {
                    handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
                    using (var client = new HttpClient(handler))
                    {
                        List<KeyValuePair<string, string>> requestData = new List<KeyValuePair<string, string>>();

                        requestData.Add(new KeyValuePair<string, string>("client_secret", _configuration["AppSettings:MailClientSecret"]));

                        requestData.Add(new KeyValuePair<string, string>("client_id", _configuration["AppSettings:MailClientId"]));

                        requestData.Add(new KeyValuePair<string, string>("grant_type", _configuration["AppSettings:MailGrantType"]));

                        requestData.Add(new KeyValuePair<string, string>("username", _configuration["AppSettings:MailUsername"]));

                        requestData.Add(new KeyValuePair<string, string>("password", _configuration["AppSettings:MailPassword"]));

                        FormUrlEncodedContent requestBody = new FormUrlEncodedContent(requestData);

                        var request = await client.PostAsync(_configuration["AppSettings:MailTokenUrl"], requestBody);

                        response = request.Content.ReadAsStringAsync().Result;

                        _logger.LogInformation($"Token Response: {response}");

                    }
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($" Token::  {ex.Message} :: {ex.StackTrace}  :: {ex.Source}");
            }

            return JsonConvert.DeserializeObject<AccessToken>(response);

        }

        private static LinkedResource getEmbeddedImage(String filePath, string cid)
        {
            LinkedResource res = new LinkedResource(filePath, MediaTypeNames.Image.Jpeg)
            {
                ContentId = cid
            };

            return res;
        }


        private string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: return input;
                case "": return input;
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }
    }
}
