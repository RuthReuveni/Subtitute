using AutoMapper;
using SubtituteDL;
using SubtituteDL.Models;
using SubtituteDTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteBL
{
    public class LessonBL : ILessonBL
    {
        public IMapper _mapper;
        ILessonDL _lessonDl;
        public LessonBL(ILessonDL lessonDl, IMapper mapper)
        {
            _lessonDl = lessonDl;
            _mapper = mapper;
        }

        public List<LessonDTO> getLessons()
        {
            List<Lesson> lessonList = _lessonDl.GetLessons();
            List<LessonDTO> resualt = _mapper.Map<List<LessonDTO>>(lessonList);


            //lessonList.ForEach(l =>
            //{
            //    Specialization specialization = _substituteDbContext.Specializations.FirstOrDefault(s => s.SpecializationId == lessonList);


            //})
            //Specialization specialization = _substituteDbContext.Specializations.FirstOrDefault(s => s.SpecializationId == lessonList);

            return resualt;
        }

        public LessonDTO UpdateLesson(LessonDTO lesson, int id)
        {
            try { 
            Lesson resualt = _mapper.Map<LessonDTO,Lesson>(lesson);
            var updatedLesson = _lessonDl.UpdateLesson(resualt, id);
            return _mapper.Map<LessonDTO>(updatedLesson);}
            catch (Exception ex) 
            {
                return null;
            }        
        }

    }
}
