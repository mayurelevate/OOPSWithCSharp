using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using testProject.DAL;

namespace testProject
{
    public partial class SendEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDataToGrid();
            }
        }

        private void BindDataToGrid()
        {
            DataTable data = GetClientData();
            grdClientDetails.DataSource = data;
            grdClientDetails.DataBind();
        }

        private DataTable GetClientData()
        {
            try
            {
                ClientDetail objClientDetail = new ClientDetail();
                DataTable dt = objClientDetail.GetClientData();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }
        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                string EmployeeId = string.Empty;

                List<UserDetails> listUserDetails = new List<UserDetails>();


                foreach (GridViewRow row in grdClientDetails.Rows)
                {                

                    if ((row.FindControl("chkEmployeeId") as CheckBox).Checked)
                    {

                        UserDetails objUserDetails = new UserDetails();
                        objUserDetails.userId = Convert.ToInt32(grdClientDetails.DataKeys[row.RowIndex].Value).ToString();
                        objUserDetails.username = row.Cells[2].Text;
                        objUserDetails.useremail = row.Cells[3].Text;
                        listUserDetails.Add(objUserDetails);

                        //EmployeeId += Convert.ToInt32(grdClientDetails.DataKeys[row.RowIndex].Value).ToString() + ",";
                        //string name = row.Cells[2].Text;
                    }
                }

                //ClientDetail objClientDetail = new ClientDetail();
                //DataTable dt = objClientDetail.GetSelectedClientData(EmployeeId);

                //UserDetails objUserDetails = new UserDetails();
                //objUserDetails.sendmail(dt);

                EmailService.SendEmailSendGrid(listUserDetails);

                BindDataToGrid();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {

            }
        }
    }
}