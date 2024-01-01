using SubtituteDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDL
{
    public interface ILessonDL
    {
         List<Lesson> GetLessons();
        Lesson UpdateLesson(Lesson lesson, int id);
    }
}
