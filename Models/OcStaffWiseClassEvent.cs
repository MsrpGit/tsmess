using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class OcStaffWiseClassEvent
{
    public long ClassEventId { get; set; }

    public int ClassId { get; set; }

    public int? Section { get; set; }

    public int SubjectId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime? EventStartDate { get; set; }

    public string? EventStartTime { get; set; }

    public DateTime? EventEndDate { get; set; }

    public string? EventEndTime { get; set; }

    public string? UrlName { get; set; }

    public bool Status { get; set; }

    public long AcademicYearId { get; set; }

    public long PartnerId { get; set; }

    public string? MonitorStaffId { get; set; }

    public long BatchId { get; set; }

    public string PeriodIdOrders { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string EventStatus { get; set; } = null!;

    public string EventTopic { get; set; } = null!;
}
