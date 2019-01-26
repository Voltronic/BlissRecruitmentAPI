using BlissRecruitmentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace BlissRecruitmentAPI.Mail
{
    public static class MailSender
    {
        public static bool SendEmail(string destination_email, string content_url)
        {
            try
            {
                string htmlBody = content_url;

                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential("mydjenerg@gmail.com", "Pa$$w0rd#Gmail"),
                    EnableSsl = true
                };

                var mail = new MailMessage()
                {
                    From = new MailAddress("mydjenerg@gmail.com"),
                    Subject = "BlissRecruitmentAPI - Sharing with you...",
                    IsBodyHtml = true
                };

                mail.To.Add(destination_email);
                mail.Body = htmlBody;

                SmtpServer.Send(mail);

                return true;
            }
            catch (Exception) { return false; }
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