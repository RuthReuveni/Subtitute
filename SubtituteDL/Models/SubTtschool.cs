using System;
using System.Collections.Generic;

namespace SubtituteDL.Models;

public partial class SubTtschool
{
    public int SubTtschoolId { get; set; }

    public int SubTtid { get; set; }

    public int SchoolId { get; set; }

    public bool? Status { get; set; }

    public virtual School School { get; set; } = null!;

    public virtual SubTt SubTt { get; set; } = null!;
}
