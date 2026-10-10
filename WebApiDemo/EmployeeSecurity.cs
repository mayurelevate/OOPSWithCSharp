using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDataAccess;

namespace WebApiDemo
{
    public class EmployeeSecurity
    {
        // For Authentication to check whethere user is Genuine or not
        public static bool Login(string userName,string password)
        {
            try
            {
                using (WebApiEmployeeDBEntities entities = new WebApiEmployeeDBEntities())
                {
                    return entities.Users.Any(user => user.Username.Equals(userName, StringComparison.OrdinalIgnoreCase) && user.Password == password);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}