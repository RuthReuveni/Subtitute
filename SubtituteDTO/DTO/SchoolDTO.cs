using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDTO.DTO
{
    public class SchoolDTO
    {
        public int SchoolId { get; set; }

        public string SchoolName { get; set; } = null!;

        public string ManagerName { get; set; } = null!;

        public string ManagerId { get; set; } = null!;

        public int AreasId { get; set; }

        public string City { get; set; } = null!;

        public string Street { get; set; } = null!;

        public int Network { get; set; }

        public double? Payment { get; set; }

        public string SchoolPhone { get; set; } = null!;

        public string SchoolEmail { get; set; } = null!;

        public string? Password { get; set; }

      //  public virtual AreaDTO Areas { get; set; } = null!;
    }
}
