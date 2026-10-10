using Newtonsoft.Json;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendGridEmailWithTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            var sendGridClient = new SendGridClient("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");

            var sendGridMessage = new SendGridMessage();
            sendGridMessage.SetFrom("naktodemayur@irstechnologies.com", "Mayur Naktode IRS");
            sendGridMessage.AddTo("naktodemayur@gmail.com", "Mayur Gmail");
            sendGridMessage.SetTemplateId("d-b51025ef09e649f4b8a724c0b8618836");
            sendGridMessage.SetTemplateData(new HelloEmail
            {
                Name = "Mayur Naktode",
                Url = "https://www.vivienfabing.com"
            });

            var response = sendGridClient.SendEmailAsync(sendGridMessage).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                Console.WriteLine("Email sent");
            }
        }

        private class HelloEmail
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
        }
    }
}
