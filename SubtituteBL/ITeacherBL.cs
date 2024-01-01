using SubtituteDL.Models;
using SubtituteDTO.DTO;

namespace SubtituteBL
{
    public interface ITeacherBL
    {
        Task<TeacherDTO> AddTeacher(TeacherDTO teacherDTO);
        Task<TeacherDTO> DeleteTeacher(TeacherDTO teacherDTO, int id);
        Task<List<TeacherDTO>> GetAllTeachers();
        Task<TeacherDTO> GetTeacherById(int id);
        Task<TeacherDTO> UpdateTeacher(TeacherDTO teacherDTO, int id);
    }
}