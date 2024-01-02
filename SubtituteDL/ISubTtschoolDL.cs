using SubtituteDL.Models;

namespace SubtituteDL
{
    public interface ISubTtschoolDL
    {
        Task<SubTtschool> AddTeacherSub(SubTtschool teacherSub);
        Task<SubTtschool> DeleteTeacherSub(SubTtschool teacherSub, int id);
        Task<List<SubTtschool>> GetAllTeachersSub();
        Task<SubTtschool> GetTeacherSubById(int id);
        Task<SubTtschool> UpdateTeacherSub(SubTtschool teacherSub, int id);
    }
}