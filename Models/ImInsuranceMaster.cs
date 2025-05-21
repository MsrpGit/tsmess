using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImInsuranceMaster
{
    public long Id { get; set; }

    public string InsuranceId { get; set; } = null!;

    public string? EmployeeName { get; set; }

    public string? PolicyNumber { get; set; }

    public string? InsuranceName { get; set; }

    public DateTime? InsuranceStartDate { get; set; }

    public DateTime? InsuranceEndDate { get; set; }

    public DateTime? RenewalDate { get; set; }

    public int? NoOfDependants { get; set; }

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
