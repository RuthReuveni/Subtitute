using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtituteDTO.DTO
{
    public class TeacherDTO
    {
        public int TeacherId { get; set; }

        public string TeacherName { get; set; } = null!;

        public string IdNumberT { get; set; } = null!;

        public string PhoneT { get; set; } = null!;

        public string? EmailT { get; set; }

        public int SchoolId { get; set; }

      //  public virtual SchoolDTO School { get; set; } = null!;
    }
}
