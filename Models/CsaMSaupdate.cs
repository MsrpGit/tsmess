using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class CsaMSaupdate
{
    public long Id { get; set; }

    /// <summary>
    /// Super Admin Types will be comma separated for ex : Finance,Admission,Attendance,Performance,Lesson Plan.
    /// </summary>
    public string SuperAdminTypes { get; set; } = null!;

    /// <summary>
    /// Manual - M,   Automated - A
    /// </summary>
    public string SyncType { get; set; } = null!;

    public string? PartnerName { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    /// <summary>
    /// 0 - Pending, 1 - Success, -1  - Failed.
    /// </summary>
    public byte UpdateStatus { get; set; }

    public DateTime CreatedDate { get; set; }
}
