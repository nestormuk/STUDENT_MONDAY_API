using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STUDENT_MONDAY_API.DTOs;
using STUDENT_MONDAY_API.Models;
using STUDENT_MONDAY_API.Repositories;

namespace STUDENT_MONDAY_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // inject the repository
        private readonly IStudentRepos _studentRepos;

        private IMapper mapper;
        public StudentController(IStudentRepos repository, IMapper mapper)
        {
            _studentRepos = repository;
            this.mapper = mapper;
        }
        //create Student
        [HttpPost]
        public async Task<ActionResult<StudentDTO>> CreateStudent(StudentDTO studentDTO)
        {
            try
            {
                // map the studentDTO to student
                var student = mapper.Map<Student>(studentDTO);
                // create the student
                await _studentRepos.CreateStudentAsync(student);

                var StudentDTO = mapper.Map<StudentDTO>(student);

                return CreatedAtAction(
                    nameof( )
                    new { id = student.Id },
                    studentDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        // Retrieve all students

        [HttpGet("{id}")] 
        public 
        // retrieve one student
        // update student
        // delete student
    }
}
