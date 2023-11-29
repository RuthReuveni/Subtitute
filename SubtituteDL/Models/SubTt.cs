using System;
using System.Collections.Generic;

namespace SubtituteDL.Models;

public partial class SubTt
{
    public int SubTtid { get; set; }

    public string SubTtname { get; set; } = null!;

    public string IdNumberSubTt { get; set; } = null!;

    public string PhomeSubTt { get; set; } = null!;

    public string? EmailSubTt { get; set; }

    public int AreasId { get; set; }

    public string CitySubTt { get; set; } = null!;

    public string? StreetSubTt { get; set; }

    public bool? IsAvailable { get; set; }

    public int? SpecializationId { get; set; }

    public string? Resume { get; set; }

    public string? Comments { get; set; }

    public int SchoolId { get; set; }

    public int DurationId { get; set; }

    public virtual Area Areas { get; set; } = null!;

    public virtual Duration Duration { get; set; } = null!;

    public virtual School School { get; set; } = null!;

    public virtual ICollection<SpesializitionSubTt> SpesializitionSubTts { get; } = new List<SpesializitionSubTt>();

    public virtual ICollection<SubTtschool> SubTtschools { get; } = new List<SubTtschool>();
}
