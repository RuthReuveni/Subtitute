using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDTO.DTO
{
    public class SubTtDTO
    {
        public int SubTtid { get; set; }

        public string SubTtname { get; set; } = null!;

        public string IdNumberSubTt { get; set; } = null!;

        public string PhomeSubTt { get; set; } = null!;

        public string? EmailSubTt { get; set; }

        public int AreasId { get; set; }

        public string CitySubTt { get; set; } = null!;

        public string? StreetSubTt { get; set; }

        public bool? IsAvailable { get; set; }

        public int? SpecializationId { get; set; }

        public string? Resume { get; set; }

        public string? Comments { get; set; }

        public int SchoolId { get; set; }

        public int DurationId { get; set; }

        //public virtual AreaDTO Areas { get; set; } = null!;

        //public virtual DurationDTO Duration { get; set; } = null!;

        //public virtual SchoolDTO School { get; set; } = null!;

    }
}
