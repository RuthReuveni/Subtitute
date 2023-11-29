using System;
using System.Collections.Generic;

namespace SubtituteDL.Models;

public partial class SpecializationSubTtreq
{
    public int SpecializationSubTtid { get; set; }

    public int RequestId { get; set; }

    public int SpecializationId { get; set; }

    public virtual Request Request { get; set; } = null!;

    public virtual Specialization Specialization { get; set; } = null!;
}
