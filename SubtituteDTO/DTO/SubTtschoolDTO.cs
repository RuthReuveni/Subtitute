using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDTO.DTO
{
    public class SubTtschoolDTO
    {
        public int SubTtschoolId { get; set; }

        public int SubTtid { get; set; }

        public int SchoolId { get; set; }

        public bool Status { get; set; }

        public virtual SchoolDTO School { get; set; } = null!;

        public virtual SubTtDTO SubTt { get; set; } = null!;
    }
}
