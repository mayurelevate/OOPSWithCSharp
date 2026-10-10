using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Cors;
using EmployeeDataAccess;

namespace WebApiDemo.Controllers
{
    [EnableCorsAttribute("https://localhost:44327", "*","*"),RequireHttps]
    public class EmployeesController : ApiController
    {

        [BasicAuthentication]
        [HttpGet]
        public HttpResponseMessage LoadEmployeeList(string gender = "All")
        {
            try
            {
                string userName = Thread.CurrentPrincipal.Identity.Name;
                if (!string.IsNullOrEmpty(userName))
                {
                    using (WebApiEmployeeDBEntities entities = new WebApiEmployeeDBEntities())
                    {
                        switch (userName.ToLower())
                        {

                            case "male":
                                return Request.CreateResponse(HttpStatusCode.OK, entities.Employees.Where(x => x.Gender.ToLower() == "male").ToList());

                            case "female":
                                return Request.CreateResponse(HttpStatusCode.OK, entities.Employees.Where(x => x.Gender.ToLower() == "female").ToList());

                            default:
                                return Request.CreateResponse(HttpStatusCode.BadRequest);
                        }


                        //switch (gender.ToLower())
                        //{
                        //    case "all":
                        //        return Request.CreateResponse(HttpStatusCode.OK, entities.Employees.ToList());

                        //    case "male":
                        //        return Request.CreateResponse(HttpStatusCode.OK,entities.Employees.Where(x=>x.Gender.ToLower() == "male").ToList());

                        //    case "female":
                        //        return Request.CreateResponse(HttpStatusCode.OK, entities.Employees.Where(x => x.Gender.ToLower() == "female").ToList());

                        //    default:
                        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Value for gender must be All, Male or Female" + gender + "is invalid.");
                        //}
                    }

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.Unauthorized, "Unauthorized");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, ex);
            }

        }

        [HttpGet]
        public HttpResponseMessage LoadEmployeeById(int Id)
        {
            try
            {
                using (WebApiEmployeeDBEntities entities = new WebApiEmployeeDBEntities())
                {
                    var entity = entities.Employees.FirstOrDefault(x => x.ID == Id);

                    if (entity != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with Id = " + Id.ToString() + " Not Found");
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);                
            }
            
        }


        // The data come here from the request body
        [HttpPost]
        public HttpResponseMessage CreateEmployeeDetails([FromBody]Employee employee)
        {
            try
            {
                using (WebApiEmployeeDBEntities entities = new WebApiEmployeeDBEntities())
                {
                    entities.Employees.Add(employee);
                    entities.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, employee);

                    message.Headers.Location = new Uri(Request.RequestUri + employee.ID.ToString());

                    return message;
                }
            }
            catch (Exception ex)
            {
               return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ex);
            }
        }

        [DisableCors] // To disable Cors Policy for this methods but enable for all methods with in this controller except this.
        [HttpDelete,RequireHttps]
        public HttpResponseMessage RemoveEmployeeDetails(int ID)
        {
            try
            {
                using (WebApiEmployeeDBEntities entities = new WebApiEmployeeDBEntities())
                {
                    var entity = entities.Employees.FirstOrDefault(x => x.ID == ID);
                    
                    if (entity!=null)
                    {
                        entities.Employees.Remove(entity);
                        entities.SaveChanges();

                        var message = Request.CreateResponse(HttpStatusCode.OK, entity);

                        return message;
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound, "Employee Id " + ID.ToString() + " Not Found");
                    }

                }
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpPut]
        public HttpResponseMessage UpdateEmployeeDetails(int Id, [FromBody]Employee employee)
        {
            try
            {
                using(WebApiEmployeeDBEntities entities = new WebApiEmployeeDBEntities())
                {
                    var entity = entities.Employees.FirstOrDefault(x => x.ID == Id);

                    if(entity!=null)
                    {
                        entity.FirstName = employee.FirstName;
                        entity.LastName = employee.LastName;
                        entity.Gender = employee.Gender;
                        entity.Salary = employee.Salary;

                        entities.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, entity);

                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound, "Employee Id " + Id.ToString() + " Not Found");
                    }

                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

                
    }
}
