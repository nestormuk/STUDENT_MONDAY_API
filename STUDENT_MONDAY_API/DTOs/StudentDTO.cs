namespace STUDENT_MONDAY_API.DTOs
{
    // CREATE STUDENT
    public class StudentDTO
    {
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public String Manjor { get; set; }
        public double GPA { get; set; }

    }

    // LIST STUDENTS

    public class StudentListDTO
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public String Manjor { get; set; }
        public double GPA { get; set; }
    }
}
