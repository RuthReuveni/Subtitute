using System;
using System.Collections.Generic;

namespace SubtituteDL.Models;

public partial class Request
{
    public int RequestId { get; set; }

    public int TeacherId { get; set; }

    public int SpecializationId { get; set; }

    public string Classes { get; set; } = null!;

    public DateTime? Date { get; set; }

    public int DurationId { get; set; }

    public virtual Duration Duration { get; set; } = null!;

    public virtual Specialization Specialization { get; set; } = null!;

    public virtual ICollection<SpecializationSubTtreq> SpecializationSubTtreqs { get; } = new List<SpecializationSubTtreq>();

    public virtual Teacher Teacher { get; set; } = null!;
}
