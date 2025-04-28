using Microsoft.EntityFrameworkCore;
using STUDENT_MONDAY_API.Data;
using STUDENT_MONDAY_API.Models;

namespace STUDENT_MONDAY_API.Repositories
{
    public class StudentRepo : IStudentRepos
    {
        private readonly AppDBContext _context; // instantiate AppDBContext

        // constructor to inject the context
        public StudentRepo(AppDBContext context)
        {
            _context = context;
        }
        public async Task<Student> CreateStudentAsync(Student studentObject)
        {
            // add the student to the database
            _context.Students.Add(studentObject); // add the student to the context
            // commit the changes to the database
            await _context.SaveChangesAsync(); // save the changes to the database
            // return the student
            return studentObject; // return the student
        }

        public async Task DeleteStudentAsync(int id)
        {
            var stud = await _context.Students.FindAsync(id); // find the student by id
            if (stud != null) // check if the student exists
            {
                _context.Students.Remove(stud); // remove the student from the context
                await _context.SaveChangesAsync(); // save the changes to the database
            }
            else
            {
                throw new Exception("Student not found"); // throw an exception if the student does not exist
            }   
        }

        public async Task<Student> GetOneStudentAsync(int id)
        {
            // find the student by id
            return await _context.Students.FindAsync(id); // find the student by id
            
        }

        public async Task<IEnumerable<Student>> RetrieveAllStudentAsync()
        {
            return await _context.Students.ToListAsync(); // retrieve all students from the database

        }

        public async Task UpdateStudentAsync(Student studentObj)
        {
            _context.Entry(studentObj).State = EntityState.Modified; // set the state of the student to modified
            await _context.SaveChangesAsync(); // save the changes to the database
        }
    }
}
