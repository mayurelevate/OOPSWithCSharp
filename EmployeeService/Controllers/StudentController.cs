using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace EmployeeService.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentController : ApiController
    {
        static List<Student> students = new List<Student>()
        {
            new Student() {Id =1,Name = "Tom"},
            new Student() {Id =2, Name ="Sam"},
            new Student() {Id=3,Name="John"}
        };

        [Route("~/api/Teachers")]
        public IEnumerable<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
               new Teacher() {Id= 1,Name = "John"},
               new Teacher() {Id = 2,Name="Mike"},
               new Teacher() {Id=3,Name = "Marry"}

            };

            return teachers;
        }


        [Route()]
        public IEnumerable<Student> Get()
        {
            return students;
        }


        [Route("{id:int:range(1,2)}",Name="GetStudentById")]
        //[Route("{id:int:min(1):max(3)}")]
        //[Route("{id:int:min(1)}")]
        public Student Get(int Id)
        {
            return students.FirstOrDefault(x => x.Id == Id);
        }

        [Route("{name:alpha}")]
        public Student Get(string name)
        {
            return students.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        }


        [Route("{id}/courses")]
        public IEnumerable<string> GetStudentCourses(int id)
        {
            if (id == 1)
                return new List<string>() { "C#", "ASP.NET", "SQL Server" };
            else if (id == 2)
                return new List<string>() { "ASP.NET Web API", "C#", "SQL Server" };
            else
                return new List<string>() { "Bootstrap", "jQuery", "AngularJs" };
        }

        [Route()]
        [HttpPost]
        public HttpResponseMessage Post(Student student)
        {
            students.Add(student);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            
            response.Headers.Location = new Uri(Request.RequestUri + "/" + student.Id.ToString());

            //response.Headers.Location = new Uri(Url.Link("GetStudentById", new { id = student.Id }));

            return response;
        }

        [Route("GetStudentDetailsById/{Id:int:min(1)}")]        
        public IHttpActionResult GetStudentDetailsById(int Id)
        {
            var student = students.FirstOrDefault(x => x.Id == Id);

            if(student!=null)
            {
                return Content(HttpStatusCode.OK, student);
            }

            return Content(HttpStatusCode.NotFound, "Student Details Not Found");

            
        }



    }
}
