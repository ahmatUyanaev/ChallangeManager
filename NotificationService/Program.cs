using System;
using System.Net;
using System.Net.Mail;

namespace NotificationService
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpClient Smtp = new SmtpClient("smtp.gmail.com", 587);
            Smtp.Credentials = new NetworkCredential("uyanaev1911@gmail.com", "xxxxxxxxx.");
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("uyanaev1911@gmail.com");
            Message.To.Add(new MailAddress("uyanaev00@gmail.com"));
            Message.Subject = "тема";
            Message.Body = "сообщение";

            try
            {
                Smtp.Send(Message);
            }
            catch (SmtpException e)
            {

            }
        }
    }
}
