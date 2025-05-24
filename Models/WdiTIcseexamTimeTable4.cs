using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcseexamTimeTable4
{
    public long ExaminationId { get; set; }

    public int PartnerId { get; set; }

    public string Examination { get; set; } = null!;

    public long? AcademicYearId { get; set; }

    public int? IcseexamId { get; set; }

    public long? ExaminationNameId { get; set; }

    public string ExamBoardType { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
