using EntityFramework2.db;
using EntityFramework2.Model;

namespace WebApiExample2.Service
{
    public class StudentService : IStudentService
    {
        DemoDbContext dbContext;
        public StudentService()
        {
            dbContext = new DemoDbContext();
        }
        public void AddStudent(Student newStudent)
        {
            dbContext.Students.Add(newStudent);
            dbContext.SaveChanges();
        }

        public List<Student> GetStudents()
        {


            return null;
        }
    }
}
