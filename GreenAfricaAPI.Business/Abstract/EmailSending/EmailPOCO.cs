using System;
using System.Collections.Generic;
using System.Text;

namespace GreenAfricaAPI.Business.Abstract.EmailSending
{
    public class AccessToken
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string refresh_token { get; set; }
        public string expires_in { get; set; }
        public string scope { get; set; }
        public string jti { get; set; }
    }

    public class Sender
    {
        public string displayName { get; set; }
        public string email { get; set; }
    }


    public class Recipient
    {
        public string displayName { get; set; }
        public string email { get; set; }
        public string recipientType { get; set; }
    }

    public class Attachment
    {
        public string cid { get; set; }
        public string content { get; set; }
        public bool inline { get; set; }
        public string mime { get; set; }
        public string name { get; set; }
    }

    public class EmailModel
    {
        public string subject { get; set; }
        public string body { get; set; }
        public string footer { get; set; }
        public Sender sender { get; set; }
        public List<Recipient> recipients { get; set; }

        public List<Attachment> attachments { get; set; }
    }

    public class EmailResponse
    {
        public string code { get; set; }
        public string message { get; set; }
        public object reference { get; set; }
    }

    public class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class EmailRequest
    {
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Footer { get; set; }
        public EmailAddress Recepient { get; set; }
        public EmailAddress Sender { get; set; }
    }

    public class EmailMessage
    {
        public EmailMessage()
        {
            ToAddresses = new List<EmailAddress>();
            FromAddresses = new List<EmailAddress>();
        }

        public List<EmailAddress> ToAddresses { get; set; }
        public List<EmailAddress> FromAddresses { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Body { get; set; }

        public DateTimeOffset Date { get; set; }
    }
}
