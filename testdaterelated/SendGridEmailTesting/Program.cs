using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendGridEmailTesting
{
    class Program
    {
        static void Main(string[] args)
        {           
             Execute().Wait();
            //Task task = Task.Run(async () => await EmailUtilities.SendEmail_Signup(UserData));

            //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 -- Marketing NEw
        }

        static async Task Execute()
        {
            //var apiKey = Environment.GetEnvironmentVariable("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");
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("naktodemayur@irstechnologies.com", "Mayur Naktode IRS");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("naktodemayur@gmail.com", "Mayur Naktode Outlook");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
