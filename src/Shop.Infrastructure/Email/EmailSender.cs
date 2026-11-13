using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using LDV.Shop.Core.Abstractions;
using Resend;

namespace LDV.Shop.Infrastructure.Email
{
    public class EmailOptions
    {
        public string From { get; set; } = "";
    }
    public class EmailSender : IEmailSender
    {
        private readonly IResend _resend;
        private readonly EmailOptions _options;
        public EmailSender(IResend resend, IOptions<EmailOptions> options)
        {
            _resend = resend;
            _options = options.Value;
        }
        public async Task SendAsync(string to, string subject, string htmlBody)
        {
            var message = new EmailMessage
            {
                From = _options.From,
                Subject = subject,
                HtmlBody = htmlBody
            };
            message.To.Add(to);

            await _resend.EmailSendAsync(message);
        }

    }
}
