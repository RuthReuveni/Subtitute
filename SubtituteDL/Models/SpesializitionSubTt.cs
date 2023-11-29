using System;
using System.Collections.Generic;

namespace SubtituteDL.Models;

public partial class SpesializitionSubTt
{
    public string Id { get; set; } = null!;

    public int SpecializationId { get; set; }

    public int SubTtid { get; set; }

    public virtual Specialization Specialization { get; set; } = null!;

    public virtual SubTt SubTt { get; set; } = null!;
}
