using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace testProject.DAL
{
    public class EmailLog
    {

        private int ClientId { get; set; }
        private string ClientName { get; set; }
        private string EmailSubject { get; set; }
        private string EmailBody { get; set; }
        private string Status { get; set; }
        private string Exception { get; set; }
        private string EmailTo { get; set; }



        public int clientid
        {
            get
            {
                return ClientId;
            }

            set
            {
                this.ClientId = value;
            }
        }
        public string clientname
        {
            get
            {
                return ClientName;
            }

            set
            {
                this.ClientName = value;
            }
        }

        public string subject
        {
            get
            {
                return EmailSubject;
            }

            set
            {
                this.EmailSubject = value;
            }
        }

        public string body
        {
            get
            {
                return EmailBody;
            }

            set
            {
                this.EmailBody = value;
            }
        }

        public string status
        {

            get
            {
                return Status;
            }

            set
            {
                this.Status = value;
            }

        }

        public string exception
        {
            get
            {
                return Exception;
            }
            set
            {
                this.Exception = value;
            }
        }

        public string emailTo 
        {
            get 
            {
                return EmailTo;
            }

            set
            {
                this.EmailTo = value;
            }
        }


        public void InsertEmailLog(EmailLog obj)
        {
            SqlConnection conn = null;
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("usp_InsertEmailLog", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientId", obj.clientid.ToString().Trim());
                cmd.Parameters.AddWithValue("@ClientName", obj.clientname.ToString().Trim());
                cmd.Parameters.AddWithValue("@EmailSubject", obj.subject.ToString().Trim());
                cmd.Parameters.AddWithValue("@EmailBody", obj.body.ToString().Trim());
                cmd.Parameters.AddWithValue("@Status", obj.status.ToString().Trim());
                cmd.Parameters.AddWithValue("@Exception", obj.exception.ToString().Trim());
                cmd.Parameters.AddWithValue("@EmailTo", obj.emailTo.ToString().Trim());
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

            }

        }
    }

    
}