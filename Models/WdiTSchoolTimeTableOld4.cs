using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTSchoolTimeTableOld4
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public int? PeriodId { get; set; }

    public long? SchoolId { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }

    public int? ClassId { get; set; }

    public int? Section { get; set; }

    public int? SubjectId { get; set; }

    public string? UserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? Remarks { get; set; }

    public long? AcademicYearId { get; set; }
}
