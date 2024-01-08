using System;
using System.Collections.Generic;

namespace SubtituteDL.Models;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string TeacherName { get; set; } = null!;

    public string IdNumberT { get; set; } = null!;

    public string PhoneT { get; set; } = null!;

    public string? EmailT { get; set; }

    public int SchoolId { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<Request> Requests { get; } = new List<Request>();

    public virtual School School { get; set; } = null!;
}
