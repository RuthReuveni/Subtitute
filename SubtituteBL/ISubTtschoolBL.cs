using SubtituteDTO.DTO;

namespace SubtituteBL
{
    public interface ISubTtschoolBL
    {
        Task<SubTtschoolDTO> AddTeacherSub(SubTtschoolDTO subTtschoolDTO);
        Task<SubTtschoolDTO> DeleteTeacherSub(SubTtschoolDTO subTtschoolDTO, int id);
        Task<List<SubTtschoolDTO>> GetAllTeachersSub();
        Task<SubTtschoolDTO> GetTeacherSubById(int id);
        Task<SubTtschoolDTO> UpdateTeacherSub(SubTtschoolDTO subTtschoolDTO, int id);
    }
}