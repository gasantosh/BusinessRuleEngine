using BusinessRuleEngine.Services.Contracts.Notification;

using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace BusinessRuleEngine.Services.Shared
{
    public class EmailService : IEmailService
    {
        private readonly NotificationMetadata notificationMetadata;

        public EmailService(IConfiguration configuration)
        {
            this.notificationMetadata = configuration.GetSection("NotificationMetadata").Get<NotificationMetadata>();
        }

        public void SendMail(string emailId, string subject, string content)
        {
            var emailMessage = new EmailMessage
            {
                Reciever = new MailboxAddress(emailId),
                Sender = new MailboxAddress(this.notificationMetadata.Sender),
                Subject = subject,
                Content = content
            };

            var message = this.CreateMimeMessageFromEmailMessage(emailMessage);
            using (SmtpClient smtpClient = new SmtpClient())
            {
                smtpClient.Connect(this.notificationMetadata.SmtpServer, this.notificationMetadata.Port, true);
                smtpClient.Authenticate(this.notificationMetadata.UserName, this.notificationMetadata.Password);
                smtpClient.Send(message);
                smtpClient.Disconnect(true);
            }
        }

        private MimeMessage CreateMimeMessageFromEmailMessage(EmailMessage message)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(message.Sender);
            mimeMessage.To.Add(message.Reciever);
            mimeMessage.Subject = message.Subject;
            mimeMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            { Text = message.Content };
            return mimeMessage;
        }

        private class EmailMessage
        {
            public MailboxAddress Sender { get; set; }
            public MailboxAddress Reciever { get; set; }
            public string Subject { get; set; }
            public string Content { get; set; }
        }

        private class NotificationMetadata
        {
            public string Sender { get; set; }
            public string Reciever { get; set; }
            public string SmtpServer { get; set; }
            public int Port { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}
