using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentFeeDueDetail5
{
    public long FeeDueId { get; set; }

    public string? UserId { get; set; }

    public long? FeeHeadId { get; set; }

    public decimal? Amount { get; set; }

    /// <summary>
    /// 0 - If Student Payment is DUE.  1 - If Student Has Paid the DUE Amount.
    /// </summary>
    public bool? Status { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Remarks { get; set; }

    /// <summary>
    /// 0 - Record Deleted, 1 - Record Active
    /// </summary>
    public bool? RecStatus { get; set; }

    public long AcademicYearId { get; set; }

    /// <summary>
    /// If Fee Due for Month,Quarter,Half Yearly or Year then specify in this Column as Jan-13,Quarter-1,HYear-1, Yearly-1
    /// </summary>
    public string? FeeFor { get; set; }

    public decimal? ConcessionAmt { get; set; }

    public bool? Updateclassdue { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string Notes { get; set; } = null!;
}
