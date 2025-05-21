using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EmployeeAttendance
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

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? Reason { get; set; }

    public long OtHours { get; set; }
}
