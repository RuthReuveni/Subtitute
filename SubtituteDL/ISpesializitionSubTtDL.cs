using SubtituteDL.Models;

namespace SubtituteDL
{
    public interface ISpesializitionSubTtDL
    {
        Task<List<SpesializitionSubTt>> GetAllSpesializitionSubTts();
        Task<List<SpesializitionSubTt>> GetTeacherBySPId(int id);
    }
}