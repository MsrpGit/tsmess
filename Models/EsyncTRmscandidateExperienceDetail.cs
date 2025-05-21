using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmscandidateExperienceDetail
{
    public long Id { get; set; }

    public string RmsuserId { get; set; } = null!;

    public string? OrganisationName { get; set; }

    public string? OrganisationAddress { get; set; }

    public DateTime? DateofJoining { get; set; }

    public DateTime? Dateofleaving { get; set; }

    public string? Experience { get; set; }

    public string? Designation { get; set; }

    public string? NatureOfWork { get; set; }

    public string? MonthlyIncome { get; set; }

    public string? Reasonforleaving { get; set; }

    public string? Remarks { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? JobType { get; set; }

    public bool IsCurrentJob { get; set; }
}
