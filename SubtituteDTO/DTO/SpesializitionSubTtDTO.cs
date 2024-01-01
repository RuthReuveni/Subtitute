using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDTO.DTO
{
    public class SpesializitionSubTtDTO
    {
        public string Id { get; set; } = null!;

        public int SpecializationId { get; set; }

        public int SubTtid { get; set; }

        //public virtual SpecializationDTO Specialization { get; set; } = null!;

        //public virtual SubTtDTO SubTt { get; set; } = null!;

    }
}
