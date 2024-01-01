using AutoMapper;
using SubtituteDL.Models;
using SubtituteDTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDTO
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Area,AreaDTO>().ReverseMap();
            CreateMap<Duration,DurationDTO>().ReverseMap();
            CreateMap<Lesson, LessonDTO>();
            CreateMap<LessonDTO, Lesson>();
            CreateMap<Network, NetworkDTO>().ReverseMap();
            CreateMap<Request, RequestDTO>().ReverseMap();
            CreateMap< School,SchoolDTO>().ReverseMap();
            CreateMap< Specialization,SpecializationDTO>(); 
            CreateMap<SpecializationDTO,Specialization > (); 
            CreateMap<SpecializationSubTtreq, SpecializationSubTtreqDTO>().ReverseMap();
            CreateMap< SpesializitionSubTt,SpesializitionSubTtDTO>().ReverseMap();
            CreateMap<SubTt,SubTtDTO>().ReverseMap();
            CreateMap<SubTtschool,SubTtschoolDTO>().ReverseMap();
            CreateMap<Teacher,TeacherDTO>().ReverseMap();


        }
    }
}   
