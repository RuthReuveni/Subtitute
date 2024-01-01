using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDTO.DTO
{
    public class LessonDTO
    {
        public int IdLesson { get; set; }

        public string Subject { get; set; } = null!;

        public int SpecializationId { get; set; }

        public int Class { get; set; }

        public string? Sammary { get; set; }

        public bool? Nispachim { get; set; }

        public string? UrlDucament { get; set; }

       // public virtual SpecializationDTO Specialization { get; set; } = null!;
    }

}

