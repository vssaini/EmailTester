using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using EmailTester.Properties;

namespace EmailTester.Code
{
    class Utility
    {
        /// <summary>
        /// Send email with message. Get other details from App.config.
        /// </summary>
        public static bool SendEmail(bool enableSsl, string smtpHost, int smtpPort, string smtpUsername, string smtpPassword, string senderEmail, string recipientEmail, string senderName, string messageBody)
        {
            bool emailSent;

            try{
                // Email body
                var emailBody = string.Format(Resources.EmailBody, messageBody);

                // Create a new mail message
                var message = new MailMessage { From = new MailAddress(senderEmail, senderName) };

                // Set To and Subject            
                message.To.Add(new MailAddress(recipientEmail));
                message.Subject = Resources.EmailSubject;

                // Get the template HTML content
                var template = $"<body>{emailBody}</body>";

                // Create html view
                message.IsBodyHtml = true;
                var htmlView = AlternateView.CreateAlternateViewFromString(template, Encoding.UTF8, "text/html");
                message.AlternateViews.Add(htmlView);

                // Prepare SMTP server
                var smtp = new SmtpClient
                           {
                               Host = smtpHost,
                               Port = smtpPort,
                               EnableSsl = enableSsl,
                               Credentials = new NetworkCredential(smtpUsername, smtpPassword)
                           };

                // Send mail message
                smtp.Send(message);
                emailSent = true;
            }
            catch (Exception exc)
            {
                emailSent = false;
            }

            return emailSent;
        }

    }
}
