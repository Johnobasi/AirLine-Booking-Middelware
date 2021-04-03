using System;
using System.Collections.Generic;
using System.Text;

namespace GreenAfricaAPI.Business.Abstract.EmailSending
{

    public interface IEmailService
    {
        Task<bool> Send(EmailMessage emailMessage, bool isService = false, string appUrl = null, string name = null, string signature = "Bulk Account Opening Team");

        /// <summary>
        ///
        /// </summary>
        /// <param name="emailRequest"></param>
        /// <param name="appUrl"></param>
        /// <param name="name"></param>
        /// <param name="signature"></param>
        /// <returns></returns>
        Task<bool> SendEmail(EmailRequest emailRequest, string appUrl = null, string name = null, string signature = "Bulk Account Opening Team");
    }
}
