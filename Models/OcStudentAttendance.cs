using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class OcStudentAttendance
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public long ClassEventId { get; set; }

    public byte UserPresentStatus { get; set; }

    public DateTime EventDate { get; set; }

    public string? EventStartTime { get; set; }

    public string? EventEndTime { get; set; }

    public long AcademicYearId { get; set; }

    public long PartnerId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
