using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace BulkEmail
{
    class SendMailService
    {
        public static string senderEmailId = ConfigurationManager.AppSettings["senderEmailId"];
        public static string sendEmailPassword = ConfigurationManager.AppSettings["sendEmailPassword"];
        public static int port = Convert.ToInt32(ConfigurationManager.AppSettings["port"]);


        //[Obsolete]
        //public static string SendEmail(string recordId,string recipient,string name)
        public static string SendEmail(Model.UserDetails objUserDetails)
        {
            string result = string.Empty;
            try
            {
               
                string subject = "Bulk Test mail";
                string body = "Hello " + objUserDetails.username;

                MailMessage mm = new MailMessage(senderEmailId, objUserDetails.useremail);
                mm.Subject = subject;
                mm.Body = body;
                mm.IsBodyHtml = true;              
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential();
                NetworkCred.UserName = senderEmailId;
                NetworkCred.Password = sendEmailPassword;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = port;
                smtp.Send(mm);
                result = "Mail Send To " + objUserDetails.userId;

            }
            catch (Exception ex)
            {
                result = "Mail Not Send To" + objUserDetails.userId;
                Console.WriteLine(ex.Message + "" + ex.StackTrace.ToString());
                //throw;
            }
            finally
            {

            }
            return result;

        }

        
        [Obsolete]
        public static string SendEmail(string emailids)
        {
            string result = string.Empty;
            try
            {

                string subject = "Bulk Test mail";
                string body = "Hello ";

                MailMessage mm = new MailMessage();
                mm.From = new MailAddress(senderEmailId);
                string[] arr = emailids.Split(',');

                if (arr.Length > 0)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(arr[i]))
                        {
                            mm.To.Add(new MailAddress(arr[i]));
                        }
                    }
                }


                mm.Subject = subject;
                mm.Body = body;
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential();
                NetworkCred.UserName = senderEmailId;
                NetworkCred.Password = sendEmailPassword;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = port;
                smtp.Send(mm);
                result = "Mail Send";

            }            
            catch (SmtpFailedRecipientsException ex)
            {
                for (int i = 0; i < ex.InnerExceptions.Length; i++)
                {
                    result = "Mail Not Send";
                    SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                    Console.WriteLine("Status Code", status);
                    Console.WriteLine("Failed to deliver message to {0}",ex.InnerExceptions[i].FailedRecipient);
                    //Console.WriteLine(ex.Message + "" + ex.StackTrace.ToString());
                }
                //throw;
            }
            finally
            {

            }
            return result;

        }
    }
}
