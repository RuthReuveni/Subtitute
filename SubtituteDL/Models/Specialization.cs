using System;
using System.Collections.Generic;

namespace SubtituteDL.Models;

public partial class Specialization
{
    public int SpecializationId { get; set; }

    public string SpecializationName { get; set; } = null!;

    public virtual ICollection<Lesson> Lessons { get; } = new List<Lesson>();

    public virtual ICollection<Request> Requests { get; } = new List<Request>();

    public virtual ICollection<SpecializationSubTtreq> SpecializationSubTtreqs { get; } = new List<SpecializationSubTtreq>();

    public virtual ICollection<SpesializitionSubTt> SpesializitionSubTts { get; } = new List<SpesializitionSubTt>();
}
