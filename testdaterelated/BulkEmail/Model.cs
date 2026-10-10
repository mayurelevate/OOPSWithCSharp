using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BulkEmail
{
    class Model
    {

        public class UserDetails
        {
            private string _UserId { get; set; }
            private string _UserName { get; set; }
            private string _UserEmail { get; set; }

            public  string userId
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


            public string sendmail(DataTable data)
            {

                string processStatus = string.Empty;

                try
                {
                    Parallel.ForEach(data.AsEnumerable(), data =>
                    {
                       // Console.WriteLine("Mail To Be Send :" + data["Email"].ToString());

                        Model.UserDetails objUserDetails = new UserDetails();
                        objUserDetails.userId = data["UserId"].ToString();
                        objUserDetails.username = data["Name"].ToString();
                        objUserDetails.useremail = data["Email"].ToString();

                        bool validate = Model.UserDetails.validate(objUserDetails);
                        if (validate)
                        {
                            // Push client data to send an email.
                            string result = SendMailService.SendEmail(objUserDetails);
                            Console.WriteLine(result);
                        }
                        else
                        {
                            Console.WriteLine(objUserDetails.userId + " Email Details not valid!!");
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
}
