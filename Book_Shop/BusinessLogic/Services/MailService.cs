using BusinessLogic.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class MailService : IMailService
    {
        private readonly IConfiguration configuration;

        public MailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task SendMessageAsync(string subject, string body, string to, string? from = null)
        {
            try
            {
                MailData data = configuration.GetSection(nameof(MailData)).Get<MailData>();

                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(from ?? data.Email));
                email.To.Add(MailboxAddress.Parse(to));
                email.Subject = subject;
                email.Body = new TextPart(TextFormat.Html) { Text = body };

                using var smtp = new SmtpClient();
                smtp.CheckCertificateRevocation = false;
                await smtp.ConnectAsync(data.Host, data.Port, SecureSocketOptions.StartTls);

                await smtp.AuthenticateAsync(data.Email, data.Password);
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                // Логування або обробка виключень
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        }
    }
}
