using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImInsuranceDetail
{
    public long Id { get; set; }

    public string DependantId { get; set; } = null!;

    public string? InsuranceId { get; set; }

    public string? DependantName { get; set; }

    public string? Relation { get; set; }

    public string? Age { get; set; }

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ImInsuranceMaster? Insurance { get; set; }
}
