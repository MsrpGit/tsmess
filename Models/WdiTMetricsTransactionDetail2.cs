using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTMetricsTransactionDetail2
{
    public int Id { get; set; }

    public long PartnerId { get; set; }

    public long Smscount { get; set; }

    public long UsersCount { get; set; }

    public long EmailCount { get; set; }

    public long AdmissionsCount { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public long PrevSmsCount { get; set; }

    public long PrevUserCount { get; set; }

    public long PrevAdmissionCount { get; set; }

    public long PrevEmailCount { get; set; }

    /// <summary>
    ///  -1 ---Wrong Metrics Inserted
    /// </summary>
    public int Status { get; set; }
}
