using SubtituteDL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDL
{
    public class LessonDL : ILessonDL
    {
        SubstituteDbContext _substituteDbContext;
        public LessonDL(SubstituteDbContext substituteDbContext)
        {
            _substituteDbContext = substituteDbContext;
        }

        public List<Lesson> GetLessons()
        {
          List<Lesson> lessonList = _substituteDbContext.Lessons.ToList();
          return lessonList;
        }      
        
        public Lesson UpdateLesson(Lesson lesson,int id)
        {
            try
            {
                Lesson updatedLesson = _substituteDbContext.Lessons.FirstOrDefault(l => l.IdLesson == id);

                if (updatedLesson != null)
                {
                    updatedLesson.Nispachim = lesson.Nispachim;
                    updatedLesson.Subject = lesson.Subject;
                    updatedLesson.Sammary = lesson.Sammary;
                    updatedLesson.UrlDucament = lesson.UrlDucament;
                    updatedLesson.Class=lesson.Class;
                    _substituteDbContext.Update(updatedLesson);
                    _substituteDbContext.SaveChanges();
                }
                return updatedLesson;

            }
            catch (Exception ex)
            {
                throw new Exception("user not found");
            }
        }
    }
}
