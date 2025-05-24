using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTask4
{
    public long HomeworkTaskId { get; set; }

    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Who created task or home work
    /// </summary>
    public string CreatedBy { get; set; } = null!;

    public int ClassId { get; set; }

    public string SectionId { get; set; } = null!;

    /// <summary>
    /// H = Home work, N-Notice
    /// </summary>
    public string Type { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Details { get; set; } = null!;

    public DateTime DueDate { get; set; }

    /// <summary>
    /// 0-Pending, 1-Completed, 2 - Cancelled
    /// </summary>
    public int Status { get; set; }

    public bool? Smsrequired { get; set; }

    public bool? EmailRequired { get; set; }

    public bool? Remainder { get; set; }

    public DateOnly? RemainderDate { get; set; }

    public string? RemainderTime { get; set; }

    public string? Color { get; set; }

    public long AcademicYearId { get; set; }

    public long PartnerId { get; set; }

    public string? AttachmentName { get; set; }

    public string? AttachmentId { get; set; }

    public int? SubjectId { get; set; }
}
