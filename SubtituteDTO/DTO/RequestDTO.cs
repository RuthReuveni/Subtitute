using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDTO.DTO
{
    public class RequestDTO
    {
        public int RequestId { get; set; }

        public int TeacherId { get; set; }

        public int SpecializationId { get; set; }

        public string Classes { get; set; } = null!;

        public DateTime? Date { get; set; }

        public int DurationId { get; set; }

        //public virtual DurationDTO Duration { get; set; } = null!;

        //public virtual SpecializationDTO Specialization { get; set; } = null!;

        //public virtual TeacherDTO Teacher { get; set; } = null!;

    }
}
