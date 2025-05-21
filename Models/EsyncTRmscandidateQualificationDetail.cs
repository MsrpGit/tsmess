using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmscandidateQualificationDetail
{
    public long Id { get; set; }

    public string RmsuserId { get; set; } = null!;

    public string? QualificationTitle { get; set; }

    public string? InstituitionName { get; set; }

    public string? InstituitionAddress { get; set; }

    public string? BoardorUniversity { get; set; }

    public string? Passedyear { get; set; }

    public string? Cgpa { get; set; }

    public string? Percentage { get; set; }

    public string? NoofAttempts { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Speciality { get; set; }
}
