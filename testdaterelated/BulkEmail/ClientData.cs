using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BulkEmail
{
    class ClientData
    {
        public static DataTable GetClientDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("UserId", typeof(string)),
                        new DataColumn("Name", typeof(string)),
                        new DataColumn("Email",typeof(string)) });
                // dt.Rows.Add(1, "Mayur", "naktodemayur@gmail.com");
                dt.Rows.Add("C1001", "Naktode Mayur", "naktodemayursalesforcemay2021@gmail.com");
                dt.Rows.Add("C1002", "Madhav", "naktodemayur1992@gmail.com");
                dt.Rows.Add("C1003", "Mayur Naktode", "naktodemayur@outlook.com.com");
                dt.Rows.Add("C1004", "Madhav Naktode", "");
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
            
        }
    }
}
