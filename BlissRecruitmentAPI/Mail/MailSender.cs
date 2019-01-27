using System;
using System.Net.Mail;
using System.Configuration;

namespace BlissRecruitmentAPI.Mail
{
    public static class MailSender
    {
        public static string SendEmail(string destination_email, string content_url)
        {
            try
            {
                string htmlBody = content_url;

                SmtpClient SmtpServer = new SmtpClient(ConfigurationManager.AppSettings["MailHost"])
                {
                    Port = 587,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["MailUser"], ConfigurationManager.AppSettings["MailPass"]),
                    EnableSsl = true
                };

                var mail = new MailMessage()
                {
                    From = new MailAddress(ConfigurationManager.AppSettings["MailSender"]),
                    Subject = ConfigurationManager.AppSettings["MailSubject"],
                    IsBodyHtml = true
                };

                mail.To.Add(destination_email);
                mail.Body = htmlBody;

                SmtpServer.Send(mail);

                return "OK";
            }
            catch (Exception ex) { return ex.Message; }
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}