using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EmployeeAttendance4
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public long EnrollNo { get; set; }

    public long MachineNo { get; set; }

    public DateTime? Date { get; set; }

    public DateTime DutyOnDate { get; set; }

    public string? DutyOn { get; set; }

    public DateTime DutyOffDate { get; set; }

    public string? DutyOff { get; set; }

    public DateTime? Otdate { get; set; }

    public string? OtOn { get; set; }

    public string? OtOff { get; set; }

    public string? InOutTime { get; set; }

    public decimal? TotalHours { get; set; }

    public bool? Status { get; set; }

    public long AcademicYearId { get; set; }

    public string AttdType { get; set; } = null!;

    public bool Latecoming { get; set; }

    public bool Latestudyhour { get; set; }

    public string Remarks { get; set; } = null!;
}
