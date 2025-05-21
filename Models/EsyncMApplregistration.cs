using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncMApplregistration
{
    public long Id { get; set; }

    public string UserName { get; set; } = null!;

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public DateTime? Dob { get; set; }

    public bool? Gender { get; set; }

    public string? Mobile { get; set; }

    public string? EmailId { get; set; }

    public string? AdmissionYear { get; set; }

    public int? AdmissionClass { get; set; }

    public string? Remarks { get; set; }

    public long AcademicyearId { get; set; }

    public long PartnerId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
