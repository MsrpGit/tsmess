using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcsetermMaster5
{
    public int TermMasterId { get; set; }

    public string TermName { get; set; } = null!;

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public string ExamBoardType { get; set; } = null!;

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
