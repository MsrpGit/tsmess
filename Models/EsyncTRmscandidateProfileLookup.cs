using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmscandidateProfileLookup
{
    public long Id { get; set; }

    public string RmsuserId { get; set; } = null!;

    public bool? PersonalProfile { get; set; }

    public bool? ContactProfile { get; set; }

    public bool? EducationProfile { get; set; }

    public bool? ExperienceProfile { get; set; }

    public bool? PublicationProfile { get; set; }

    public bool? Documents { get; set; }

    public bool? CouncilReg { get; set; }

    public int? NoofAppliedJobs { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
