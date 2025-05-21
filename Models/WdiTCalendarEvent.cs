using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTCalendarEvent
{
    public long CalendarEventId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Details { get; set; } = null!;

    public DateTime DueDate { get; set; }

    /// <summary>
    /// 0-Pending, 1-Completed, 2 - Cancelled
    /// </summary>
    public byte Status { get; set; }

    public bool? Remainder { get; set; }

    public DateOnly? RemainderDate { get; set; }

    public string? RemainderTime { get; set; }

    public string? Color { get; set; }

    public long AcademicYearId { get; set; }

    public long PartnerId { get; set; }
}
