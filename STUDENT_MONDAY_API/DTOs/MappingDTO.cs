using AutoMapper;
using STUDENT_MONDAY_API.Models;
namespace STUDENT_MONDAY_API.DTOs
{
    public class MappingDTO : Profile
    {
        public MappingDTO()
        {
            CreateMap<Student, StudentDTO>();
            //CreateMap<Student, ListStudentDTO>();
        }
    }
    
}
