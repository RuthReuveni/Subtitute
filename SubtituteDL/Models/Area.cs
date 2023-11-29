using System;
using System.Collections.Generic;

namespace SubtituteDL.Models;

public partial class Area
{
    public int AreasId { get; set; }

    public string AreaName { get; set; } = null!;

    public virtual ICollection<School> Schools { get; } = new List<School>();

    public virtual ICollection<SubTt> SubTts { get; } = new List<SubTt>();
}
