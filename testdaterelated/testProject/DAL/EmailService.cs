using Newtonsoft.Json;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using testProject.DAL;

namespace testProject
{
    public static class EmailService
    {
        public static string senderEmailId = ConfigurationManager.AppSettings["senderEmailId"];
        public static string sendEmailPassword = ConfigurationManager.AppSettings["sendEmailPassword"];
        public static int port = Convert.ToInt32(ConfigurationManager.AppSettings["port"]);

        public static string SendEmail(UserDetails objUserDetails)
        {
            string result = string.Empty;
            string status = string.Empty;

            EmailLog objEmailLog = new EmailLog();
            string subject = string.Empty;
            string body = string.Empty;

            try
            {

                subject = "Bulk Test mail";
                body = "Hello </br>" + objUserDetails.username;

                MailMessage message = new MailMessage(senderEmailId, objUserDetails.useremail);
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;
              
                SmtpClient smtp = new SmtpClient();
                //smtp.Host = "smtp.gmail.com";
                //smtp.EnableSsl = true;
                //NetworkCredential NetworkCred = new NetworkCredential();
                //NetworkCred.UserName = senderEmailId;
                //NetworkCred.Password = sendEmailPassword;
                //smtp.UseDefaultCredentials = true;
                //smtp.Credentials = NetworkCred;
                //smtp.Port = port;
                smtp.Send(message);




                objEmailLog.clientid = Convert.ToInt32(objUserDetails.userId);
                objEmailLog.clientname = objUserDetails.username;
                objEmailLog.emailTo = objUserDetails.useremail;
                objEmailLog.subject = subject;
                objEmailLog.body = body;
                objEmailLog.status = "SUCCESS";
                objEmailLog.exception = string.Empty;
            }
            catch (SmtpException smtpex)
            {
                objEmailLog.clientid = Convert.ToInt32(objUserDetails.userId);
                objEmailLog.clientname = objUserDetails.username;
                objEmailLog.emailTo = objUserDetails.useremail;
                objEmailLog.subject = subject;
                objEmailLog.body = body;
                objEmailLog.status = "FAIL";
                objEmailLog.exception = smtpex.InnerException.ToString();
            }
            catch (Exception ex)
            {
                objEmailLog.clientid = Convert.ToInt32(objUserDetails.userId);
                objEmailLog.clientname = objUserDetails.username;
                objEmailLog.emailTo = objUserDetails.useremail;
                objEmailLog.subject = subject;
                objEmailLog.body = body;
                objEmailLog.status = "FAIL";
                objEmailLog.exception = ex.InnerException.ToString(); //  + "!! " + ex.StackTrace.ToString();

            }
            finally
            {

                

                objEmailLog.InsertEmailLog(objEmailLog);
            }
            return result;

        }




        public static string SendEmailSendGrid(List<UserDetails> lstUserDetails)
        {
            string result = string.Empty;
            string status = string.Empty;

            EmailLog objEmailLog = new EmailLog();
            string subject = string.Empty;
            string body = string.Empty;

            try
            {


                var sendGridClient = new SendGridClient("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");

                var sendGridMessage = new SendGridMessage();
                sendGridMessage.Subject = "Dynamic Template";
                sendGridMessage.SetFrom("naktodemayur@irstechnologies.com", "Mayur Naktode IRS");
                sendGridMessage.SetTemplateId("d-b51025ef09e649f4b8a724c0b8618836");


                var people = new List<HelloEmail>
                    {
                    
                        new HelloEmail {Name = "First1", Url = "www.google.com"},
                        new HelloEmail {Name = "First2", Url = "google.com"}
                    };






                //sendGridMessage.SetTemplateData(new HelloEmail
                //{
                //    Name = "Mayur",
                //    Url = "https://www.vivienfabing.com"
                //});

                if (sendGridMessage.Personalizations == null)
                    sendGridMessage.Personalizations = new List<Personalization>();

                var substitutionsCopy = sendGridMessage.Personalizations.FirstOrDefault()?.Substitutions;
                sendGridMessage.Personalizations.Clear();

                List<EmailAddress> list = new List<EmailAddress>();
                sendGridMessage.AddContent(MimeType.Text, "Hello {{name}}");

                var personalizationIndex = 0;
                Parallel.ForEach(lstUserDetails.AsEnumerable(), data =>
                {
                    var personalization = new Personalization();
                    personalization.Substitutions = substitutionsCopy;
                    sendGridMessage.AddSubstitution("{{name}}",data.username, personalizationIndex);
                    personalization.Tos = new List<EmailAddress>() { new EmailAddress(data.useremail) };
                    personalizationIndex++;
                    sendGridMessage.Personalizations.Add(personalization);
                   

                });

                var response = sendGridClient.SendEmailAsync(sendGridMessage).Result;
                if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                {
                    Console.WriteLine("Email sent");
                }

























                //var sendGridClient = new SendGridClient("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");

                //var sendGridMessage = new SendGridMessage();
                //sendGridMessage.SetFrom("naktodemayur@irstechnologies.com", "Mayur Naktode IRS");
                //sendGridMessage.AddTo("naktodemayur@gmail.com", "Mayur Gmail");
                //sendGridMessage.SetTemplateId("d-b51025ef09e649f4b8a724c0b8618836");
                //sendGridMessage.SetTemplateData(new HelloEmail
                //{
                //    Name = "Mayur Naktode",
                //    Url = "https://www.vivienfabing.com"
                //});

                //var response = sendGridClient.SendEmailAsync(sendGridMessage).Result;
                //if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                //{
                //    Console.WriteLine("Email sent");
                //}

            }
            catch (SmtpException smtpex)
            {
                //objEmailLog.clientid = Convert.ToInt32(objUserDetails.userId);
                //objEmailLog.clientname = objUserDetails.username;
                //objEmailLog.emailTo = objUserDetails.useremail;
                //objEmailLog.subject = subject;
                //objEmailLog.body = body;
                //objEmailLog.status = "FAIL";
                //objEmailLog.exception = smtpex.InnerException.ToString();
            }
            catch (Exception ex)
            {
                //objEmailLog.clientid = Convert.ToInt32(objUserDetails.userId);
                //objEmailLog.clientname = objUserDetails.username;
                //objEmailLog.emailTo = objUserDetails.useremail;
                //objEmailLog.subject = subject;
                //objEmailLog.body = body;
                //objEmailLog.status = "FAIL";
                //objEmailLog.exception = ex.InnerException.ToString(); //  + "!! " + ex.StackTrace.ToString();

            }
            finally
            {
                //objEmailLog.InsertEmailLog(objEmailLog);
            }
            return result;

        }

        public class HelloEmail
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
        }


        //public  void  mymethod()
        //{
        //    var apiKey = Environment.GetEnvironmentVariable("NAME_OF_THE_ENVIRONMENT_VARIABLE_FOR_YOUR_SENDGRID_KEY");
        //    var client = new SendGridClient(apiKey);
        //    var from = new EmailAddress("test@example.com", "Example User");
        //    var subject = "Sending with SendGrid is Fun";
        //    var to = new EmailAddress("test@example.com", "Example User");
        //    var plainTextContent = "and easy to do anywhere, even with C#";
        //    var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
        //    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        //    var response = await client.SendEmailAsync(msg);
        //}
    }
}