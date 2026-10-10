using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> GetEmployee()
        {
            try
            {
                // To get the username 
                //1. User.Identity.Name
                //2. RequestContext.Principal.Identity.Name

                using (WebApiEmployeeDBEntities entities = new WebApiEmployeeDBEntities())
                {
                    return entities.Employees.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
