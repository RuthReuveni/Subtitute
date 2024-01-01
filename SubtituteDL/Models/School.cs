using System;
using System.Collections.Generic;

namespace SubtituteDL.Models;

public partial class School
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

    public virtual Area Areas { get; set; } = null!;

    public virtual Network NetworkNavigation { get; set; } = null!;

    public virtual ICollection<SubTt> SubTts { get; } = new List<SubTt>();

    public virtual ICollection<SubTtschool> SubTtschools { get; } = new List<SubTtschool>();

    public virtual ICollection<Teacher> Teachers { get; } = new List<Teacher>();
}
