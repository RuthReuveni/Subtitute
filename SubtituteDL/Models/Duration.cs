using System;
using System.Collections.Generic;

namespace SubtituteDL.Models;

public partial class Duration
{
    public int DurationId { get; set; }

    public string DurationName { get; set; } = null!;

    public virtual ICollection<Request> Requests { get; } = new List<Request>();

    public virtual ICollection<SubTt> SubTts { get; } = new List<SubTt>();
}
