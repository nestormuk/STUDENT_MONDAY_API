using STUDENT_MONDAY_API.Models;

namespace STUDENT_MONDAY_API.Repositories
{
    public interface IStudentRepos
    {

        // create student 
        Task<Student> CreateStudentAsync(Student student);
        // retrieve all students
        Task<IEnumerable<Student>> RetrieveAllStudentAsync();
        // retrive one student 
        Task<Student> GetOneStudentAsync(int id);
        // update student
        Task UpdateStudentAsync(Student student);
        // delete student
        Task DeleteStudentAsync(int id);

    }
}
