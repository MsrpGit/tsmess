using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTExamSchedule4
{
    public long ScheduleId { get; set; }

    public int ExaminationId { get; set; }

    public int ClassId { get; set; }

    public int? Section { get; set; }

    public int? SubjectId { get; set; }

    public DateTime? ExamDate { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }

    public decimal Marks { get; set; }

    public decimal InternalMarks { get; set; }

    public decimal ExternalMarks { get; set; }

    public short Status { get; set; }

    public string? Remarks { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsCce { get; set; }

    public string? ExamType { get; set; }

    public DateTime? InternalExamDate { get; set; }

    public string? InternalFromTime { get; set; }

    public string? InternalToTime { get; set; }

    public string? InternalTitle { get; set; }

    public string? ExternalTitle { get; set; }

    public bool? IsProcessed { get; set; }
}
