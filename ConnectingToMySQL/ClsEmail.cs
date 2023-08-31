using System;

using System.Net;
using System.Net.Mail;

namespace ConnectingToMySQL
{
    internal class Email
    {
        public static void SendEmail()
        {
            MailAddress to = new MailAddress("ellen_luna@yahoo.com");
            MailAddress from = new MailAddress("ellen_luna@yahoo.com");

            MailMessage email = new MailMessage(from, to);
            email.Subject = "Testing out email sending";
            email.Body = "Hello all the way from the land of C#";

            //var builder = new BodyBuilder();
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 25;
            smtp.Credentials = new NetworkCredential("smtp_username", "smtp_password");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            try
            {
                /* Send method called below is what will send off our email 
                 * unless an exception is thrown.
                 */
                smtp.Send(email);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}