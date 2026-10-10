using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BulkEmail
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //To Get Client Data for Sending an email
                DataTable clientdata = ClientData.GetClientDetails();
                Model.UserDetails objModel = new Model.UserDetails();
                string serviceResponse = objModel.sendmail(clientdata);
                Console.WriteLine("Service Status " + serviceResponse);               
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            finally
            {
                Environment.Exit(0);
            }
           



            //foreach (DataRow dt in clientdata.Rows)
            //{
            //    string result = SendMailService.SendEmail(dt["UserId"].ToString(), dt["Email"].ToString(), dt["Name"].ToString());
            //    Console.WriteLine(result);
            //}

            //string clientmail = string.Empty;

            //foreach (DataRow m in clientdata.Rows)
            //{
            //    clientmail += m["Email"].ToString() + ",";
            //}

            //SendMailService.SendEmailNew(clientmail);

        }

     
    }
}
