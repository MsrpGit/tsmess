using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmscandidateJobProfile
{
    public long? Id { get; set; }

    public string? RmsuserId { get; set; }

    public string? Position { get; set; }

    public bool Personal { get; set; }

    public bool Contact { get; set; }

    public bool Qualification { get; set; }

    public bool Experience { get; set; }

    public bool Publication { get; set; }

    public bool Documents { get; set; }

    public bool Historic { get; set; }

    public bool MedicalCouncil { get; set; }

    public bool NoofAppliedJobs { get; set; }

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
