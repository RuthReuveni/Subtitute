using System;
using System.Collections.Generic;

namespace SubtituteDL.Models;

public partial class Lesson
{
    public int IdLesson { get; set; }

    public string Subject { get; set; } = null!;

    public int SpecializationId { get; set; }

    public int Class { get; set; }

    public string? Sammary { get; set; }

    public bool? Nispachim { get; set; }

    public string? UrlDucament { get; set; }

    public virtual Specialization Specialization { get; set; } = null!;
}
