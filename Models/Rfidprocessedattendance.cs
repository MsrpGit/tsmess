using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class Rfidprocessedattendance
{
    public long Id { get; set; }

    public string? AttendanceId { get; set; }

    public string? Name { get; set; }

    public string? ClassBatch { get; set; }

    public DateTime? AttendanceDate { get; set; }

    public string? AttDate { get; set; }

    public string? AttendanceTime { get; set; }

    public int? HourTime { get; set; }

    public string? PreviPunch { get; set; }

    public int? HoursAttended { get; set; }

    public string? Timings { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
