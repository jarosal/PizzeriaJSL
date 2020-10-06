using System;
using System.Net;
using System.Net.Mail;
using Pizzeria.Data.Models;

namespace Pizzeria.Core
{
    public static class EmailHelper
    {
        public static string BuildEmailBody(User user, Order order)
        {
            string body = $"Zamówienie dla użytkownika: {user.Login}";
            body += Environment.NewLine;

            foreach (var product in order.Products)
            {
                body += $"{product.Name} - {product.Price}";
                body += Environment.NewLine;

                foreach (var addition in product.Additions)
                {
                    body += $"{addition.Name} - {addition.Price}";
                    body += Environment.NewLine;
                }
            }

            body += Environment.NewLine;
            body += $"Kwota całkowita: {order.TotalAmount} zł";

            return body;
        }

        public static void SendEmail(string body, string toEmail)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("jsltest789@gmail.com");
                message.To.Add(new MailAddress(toEmail));
                message.Subject = "Pizzeria - Zamówienie";
                message.Body = body;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("#", "#");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception)
            {
            }
        }
    }
}