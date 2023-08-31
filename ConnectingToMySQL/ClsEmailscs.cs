using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI;

namespace ConnectingToMySQL
{
    internal class ClsEmailscs
    {
        public static void SendEmail()
        {
            string smtp_username = ConnectingToMySQL.Properties.Settings.Default.UsernameEmail.ToString();
            string smtp_password = ConnectingToMySQL.Properties.Settings.Default.PWEmail.ToString();

            MailAddress to = new MailAddress(smtp_username);
            MailAddress from = new MailAddress(smtp_username);

            MailMessage email = new MailMessage(from, to);
            email.Subject = "Testing out email sending";
            email.Body = "Hello all the way from the land of C#";
                       //var builder = new BodyBuilder();
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = true;
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(smtp_username, smtp_password);
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

        public static void Email2()
        {
            MailMessage msg = new MailMessage();

            msg.From = new MailAddress("ellenluna78@gmail.com");
            msg.To.Add("ellen_luna@yahoo.com");
            msg.Subject = "test";
            msg.Body = "Test Content";
            //msg.Priority = MailPriority.High;


            using (SmtpClient client = new SmtpClient())
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("ellenluna78@gmail.com", "Azariah@01");
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(msg);
            }

        }
    }
}
