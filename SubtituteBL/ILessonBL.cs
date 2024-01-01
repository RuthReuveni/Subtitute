using SubtituteDL.Models;
using SubtituteDTO.DTO;

namespace SubtituteBL
{
    public interface ILessonBL
    {
        List<LessonDTO> getLessons();
        LessonDTO UpdateLesson(LessonDTO lesson, int id);
    }
}