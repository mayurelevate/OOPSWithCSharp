using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using static testProject.EmailService;

namespace testProject.DAL
{

    public class UserDetails
    {
        private string _UserId { get; set; }
        private string _UserName { get; set; }
        private string _UserEmail { get; set; }

        public string userId
        {
            get
            {
                return _UserId;
            }

            set
            {
                this._UserId = value;
            }
        }


        public string username
        {
            get
            {
                return _UserName;
            }

            set
            {
                this._UserName = value;
            }
        }


        public string useremail
        {
            get
            {
                return _UserEmail;
            }

            set
            {
                this._UserEmail = value;
            }
        }


        public List<HelloEmail> lstHelloEmail { get; set; }



        public string sendmail(DataTable data)
        {

            string processStatus = string.Empty;

            try
            {
                Parallel.ForEach(data.AsEnumerable(), item =>
                {
                        // Console.WriteLine("Mail To Be Send :" + data["Email"].ToString());

                     UserDetails objUserDetails = new UserDetails();
                    objUserDetails.userId = item["EmployeeId"].ToString();
                    objUserDetails.username = item["FirstName"].ToString();
                    objUserDetails.useremail = item["Email"].ToString();

                    bool validate = UserDetails.validate(objUserDetails);
                    if (validate)
                    {
                        // Push client data to send an email.
                        string result = EmailService.SendEmail(objUserDetails);
                        //Console.WriteLine(result);
                    }
                    else
                    {
                        //Console.WriteLine(objUserDetails.userId + " Email Details not valid!!");
                    }
                });

                processStatus = "SUCCESS";

            }
            catch (Exception)
            {
                processStatus = "FAIL";
                throw;
            }
            finally
            {

            }
            return processStatus;
        }


        public List<UserDetails> sendmailSendGrid(DataTable data)
        {

            string processStatus = string.Empty;
            List<UserDetails> lstUserDetails = new List<UserDetails>();
            try
            {
                Parallel.ForEach(data.AsEnumerable(), item =>
                {
                    // Console.WriteLine("Mail To Be Send :" + data["Email"].ToString());

                    UserDetails objUserDetails = new UserDetails();
                    objUserDetails.userId = item["EmployeeId"].ToString();
                    objUserDetails.username = item["FirstName"].ToString();
                    objUserDetails.useremail = item["Email"].ToString();

                    bool validate = UserDetails.validate(objUserDetails);
                    if (validate)
                    {
                        // Push client data to send an email.
                        //string result = EmailService.SendEmail(objUserDetails);
                        //Console.WriteLine(result);
                        lstUserDetails.Add(objUserDetails);
                    }
                    else
                    {
                        //Console.WriteLine(objUserDetails.userId + " Email Details not valid!!");
                    }
                });

                processStatus = "SUCCESS";

            }
            catch (Exception)
            {
                processStatus = "FAIL";
                throw;
            }
            finally
            {

            }
            return lstUserDetails;
        }


        private static bool validate(UserDetails obj)
        {
            try
            {
                bool result = false;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(obj.useremail);

                if (!string.IsNullOrEmpty(obj.userId) && !string.IsNullOrEmpty(obj.username) && !string.IsNullOrEmpty(obj.useremail) && match.Success)
                {
                    result = true;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            finally
            {

            }


        }
    }
}