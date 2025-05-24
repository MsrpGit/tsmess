using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentFeeDetail5
{
    public long StudentFeeId { get; set; }

    public string UserId { get; set; } = null!;

    public decimal? TotalAmountToBePaid { get; set; }

    public decimal? OldDues { get; set; }

    public DateTime? LastPaidDate { get; set; }

    public string? Remarks { get; set; }

    public long AcademicYearId { get; set; }
}
