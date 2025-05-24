using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncMAppluser1
{
    public long Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? UserType { get; set; }

    public DateTime? LastVisit { get; set; }

    public int Status { get; set; }

    public string? Permissions { get; set; }

    public int SusertypeId { get; set; }

    public string? SuserType { get; set; }

    public string? Shahs { get; set; }

    public string? Sslat { get; set; }

    public bool IsFirstLogin { get; set; }

    public long? ApplRefId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
