using System;
using System.Net;
using System.Net.Mail;

namespace TheChicken
{
    public static class EmailSender
    {
        public static bool SendMail(string ToEmail, string subject, string Body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(ToEmail);
                // mail.To.Add("Another Email ID where you wanna send same email");
                mail.From = new MailAddress("whiteangelcs1830@gmail.com", "MyApp Backup");
                mail.Subject = subject;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                mail.CC.Add("whiteangelcs1830@gmail.com");
                mail.Attachments.Add(new Attachment("c:\\Chiken.bak"));
                SmtpClient smtp = new SmtpClient();
                //smtp.Port = 25;
                //smtp.Host = "mail.pakjobpoint.com"; //Or Your email hosting Server Address
                //smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new NetworkCredential("whiteangelcs1830@gmail.com", "angel1830");
                //Or your Smtp Email ID and Password
                //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}