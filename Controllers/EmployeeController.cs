using EntityFramework2.db;
using EntityFramework2.Model;
using Microsoft.AspNetCore.Mvc;
using WebApiExample2.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiExample2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET: api/<EmployeeController>
        DemoDbContext dbContext;

        IStudentService studentService;
        public EmployeeController()
        {

            dbContext= new DemoDbContext();
            studentService= new StudentService();

        }
    
        [HttpPost]
        public void Post([FromBody] Student newStudent )
        {
           

          studentService.AddStudent(newStudent);
              
      
          
        }

        [HttpGet]
        public List<Student> Get()
        {
          
            return dbContext.Students.ToList();

        }

        [HttpGet("GetStudentDetails")]
        public Student GetStudentDetails(int id)
        {
           
            Student s1= dbContext.Students.Where(x=>x.Id== id).FirstOrDefault();

            return s1;

        }

        [HttpDelete("RemoveStudnet")]
        public void RemoveStudent(int id)
        {
           
            Student s1= dbContext.Students.Where(x => x.Id == id).FirstOrDefault();
           
            
            dbContext.Students.Remove(s1);
            dbContext.SaveChanges();
            //return dbContext.Students.Where(x => x.Id == id).FirstOrDefault();

        }


        [HttpGet("Vishnu")]
        public void Vishnu()
        {

        }
    }

   
}
