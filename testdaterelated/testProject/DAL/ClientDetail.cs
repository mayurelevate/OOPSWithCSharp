using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace testProject.DAL
{
    public class ClientDetail
    {
      
        public DataTable GetClientData()
        {
            SqlConnection conn = null;
            try
            {

                string connString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("usp_GetClientData", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;             

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

            }
            
        }


        public DataTable GetSelectedClientData(string ClientIds)
        {
            SqlConnection conn = null;
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("usp_GetData", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id",  ClientIds.TrimEnd(','));
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
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