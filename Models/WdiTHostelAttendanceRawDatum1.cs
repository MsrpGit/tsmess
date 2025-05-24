using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTHostelAttendanceRawDatum1
{
    public long Id { get; set; }

    public string AttendanceId { get; set; } = null!;

    public DateOnly? AttendanceDate { get; set; }

    public TimeOnly? AttendanceTime { get; set; }

    public string? EnrollNo { get; set; }

    public string? MachineNo { get; set; }

    public string? AttnDetails { get; set; }

    public string? Remarks { get; set; }

    public long AcademicyearId { get; set; }

    public long PartnerId { get; set; }

    public bool UserAssigned { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
