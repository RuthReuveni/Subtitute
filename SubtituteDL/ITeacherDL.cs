using SubtituteDL.Models;

namespace SubtituteDL
{
    public interface ITeacherDL
    {
        Task<Teacher> AddTeacher(Teacher teacher);
        Task<bool> DeleteTeacher(int id);
        Task<List<Teacher>> GetAllTeachers();
        Task<Teacher> GetTeacherById(int id);
        Task<Teacher> UpdateTeacher(Teacher teacher, int id);
    }
}