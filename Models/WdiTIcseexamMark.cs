using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcseexamMark
{
    public long MarksId { get; set; }

    public long ScheduleId { get; set; }

    public string UserId { get; set; } = null!;

    public decimal? SecuredMarks { get; set; }

    public decimal? InternalMarks { get; set; }

    public string AbsentType { get; set; } = null!;

    public bool? IsInternalAbsent { get; set; }

    public string? Grade { get; set; }

    public decimal? GradePoint { get; set; }

    public string? Status { get; set; }

    public decimal? Tsscore { get; set; }

    public string? Tsgrade { get; set; }

    public decimal? Tgp { get; set; }

    public string? Remarks { get; set; }

    public int? ClassRank { get; set; }

    public int? SectionRank { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
