using System.Net;
using System.Net.Mail;

namespace WebApi
{
    public class Mail
    {
        public static bool SendMail(string sender, string receiver, string messageBody, string subject, string hostName, string userName, string password)
        {
            var oMail = new MailMessage(new MailAddress(sender), new MailAddress(receiver))
            {
                Body = messageBody,
                Subject = subject
            };

            var oSmtp = new SmtpClient
            {
                Host = hostName,
                Credentials = new NetworkCredential(userName, password),
                EnableSsl = false
            };
            oSmtp.Send(oMail);
            return true;
        }
    }
}