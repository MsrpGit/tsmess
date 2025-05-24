using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMLeaveType5
{
    public int Id { get; set; }

    public string LeaveType { get; set; } = null!;

    public string LeaveTypeName { get; set; } = null!;

    public decimal DaysEligibleMonth { get; set; }

    public decimal EligibleForYear { get; set; }

    public bool Encashable { get; set; }

    public bool CarryForward { get; set; }

    public long? AcademicYearId { get; set; }

    public byte IsMandatoryDocs { get; set; }

    public string RecommendedByRole { get; set; } = null!;

    public string? AuthorizedByRole { get; set; }

    public string? ForwardedByRole { get; set; }

    public string ApprovedByRole { get; set; } = null!;

    public bool IsZeroBalance { get; set; }

    public int DeductionHead { get; set; }

    public decimal DeductionPercentage { get; set; }
}
