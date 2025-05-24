using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTOutPassDetail2
{
    public long Id { get; set; }

    public string PermissionId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? AdmissionNo { get; set; }

    public string Name { get; set; } = null!;

    public string ParentType { get; set; } = null!;

    public string ParentName { get; set; } = null!;

    public string? Class { get; set; }

    public string? Section { get; set; }

    public DateTime? OutDateTime { get; set; }

    public DateTime? InDateTime { get; set; }

    public string Status { get; set; } = null!;

    public string Reason { get; set; } = null!;

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string PermissionGivenBy { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
