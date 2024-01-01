using System;
using System.Collections.Generic;

namespace SubtituteDL.Models;

public partial class Network
{
    public int NetworkId { get; set; }

    public string NetworkName { get; set; } = null!;

    public virtual ICollection<School> Schools { get; } = new List<School>();
}
