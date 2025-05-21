using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTLateAttendanceCounting
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public byte LateCountDays { get; set; }

    public int LateCountMinutes { get; set; }

    public byte ConfirmedLateCountDays { get; set; }

    public int ConfirmedLateCountMinutes { get; set; }

    public string Month { get; set; } = null!;

    public long PartnerId { get; set; }

    public string Status { get; set; } = null!;

    public string Remarks { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ConfirmedBy { get; set; }

    public DateTime? ConfirmedDate { get; set; }

    public int EarlyCountDays { get; set; }

    public int EarlyCountMinutes { get; set; }

    public int ConfirmedEarlyCountDays { get; set; }

    public int ConfirmedEarlyCountMinutes { get; set; }

    public decimal Lopdays { get; set; }

    public decimal ConfirmedLopdays { get; set; }
}
