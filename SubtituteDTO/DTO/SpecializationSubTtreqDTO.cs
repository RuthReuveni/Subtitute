using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDTO.DTO
{
    public class SpecializationSubTtreqDTO
    {
        public int SpecializationSubTtid { get; set; }

        public int RequestId { get; set; }

        public int SpecializationId { get; set; }

        //public virtual RequestDTO Request { get; set; } = null!;

        //public virtual SpecializationDTO Specialization { get; set; } = null!;
    }
}
