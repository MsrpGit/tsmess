using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmscandidateCouncilReg
{
    public long Id { get; set; }

    public string RmsuserId { get; set; } = null!;

    public string? RegNo { get; set; }

    public string? RegState { get; set; }

    public DateTime? RegValidUpto { get; set; }

    public string? RegComments { get; set; }

    public string? RegVerificationUrl { get; set; }

    public string? RegAuthorityUrl { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Qualification { get; set; }
}
