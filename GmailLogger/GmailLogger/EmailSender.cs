using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GmailLogger
{
    public static class EmailSender
    {
        private static string[] Scopes = { GmailService.Scope.GmailCompose, GmailService.Scope.GmailSend };
        private static string ApplicationName = "Gmail API Quickstart";

        public static void SendEmail(string to,string subject, string body, string attachment)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(
                    Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Gmail API service.
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            MailMessage msg = new MailMessage(); //System.Net.Mail
            msg.Subject = subject;
            msg.Body = body;
            if(attachment != "")
            {
                msg.Attachments.Add(new Attachment(attachment));
            }
            msg.To.Add(new MailAddress(to));
            msg.From = new MailAddress("lewissavage88@gmail.com");
            MimeMessage message = MimeMessage.CreateFromMailMessage(msg); //MimeKit conversion
            var result = service.Users.Messages.Send(new Google.Apis.Gmail.v1.Data.Message
            {
                Raw = Base64UrlEncode(message.ToString())
            }, "me").Execute();
        }
        public static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            // Special "url-safe" base64 encode.

            return System.Convert.ToBase64String(inputBytes)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
        }
    }

}
