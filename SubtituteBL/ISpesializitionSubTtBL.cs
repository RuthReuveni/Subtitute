using SubtituteDTO.DTO;

namespace SubtituteBL
{
    public interface ISpesializitionSubTtBL
    {
        Task<List<SpesializitionSubTtDTO>> GetAllSpesializitionSubTts();
        Task<SpesializitionSubTtDTO> GetTeacherBySPId(int id);
    }
}