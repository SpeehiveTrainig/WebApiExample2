using EntityFramework2.Model;

namespace WebApiExample2.Service
{
    public interface IStudentService
    {
        public void AddStudent(Student student);
        

        public List<Student> GetStudents();
    }
}
