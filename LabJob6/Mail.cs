using System;
using System.Net;
using System.Net.Mail;

namespace LabJob6
{
    class Mail
    {
        private static Mail MailSingleton { get; set; }


        protected Mail() => Console.WriteLine("Сообщение отправлено");


        public static Mail GetInstance()
        {
            if (MailSingleton == null)
            {
                MailSingleton = new Mail();
            }

            return MailSingleton;
        }

        public void MailSender(string mailAddress, string mailText)
        {
            string smtpServer = "smtp.mail.ru";
            int smtpPort = 587;
            string smtpUsername = "vladimirtestmail@mail.ru";
            string smtpPassword = "jsg5S3rjMWrDNvYg7Wy2";


            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername);
                    mailMessage.To.Add(mailAddress);
                    mailMessage.Subject = "Заголовок сообщения (тема)";
                    mailMessage.Body = $"{mailText}";

                    try
                    {
                        smtpClient.Send(mailMessage);
                        Console.WriteLine("Сообщение успешно отправлено.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка отправки сообщения: {ex.Message}");
                    }
                }
            }
        }
    }
}