using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncMRmsuser
{
    public long Id { get; set; }

    public string RmsuserId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string? EmailId { get; set; }

    public string? Status { get; set; }

    public string Password { get; set; } = null!;

    public int? UserType { get; set; }

    public DateTime? LastVisit { get; set; }

    public int SusertypeId { get; set; }

    public string? SuserType { get; set; }

    public string? Shahs { get; set; }

    public string? Sslat { get; set; }

    public bool IsFirstLogin { get; set; }

    public string? Reason { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
