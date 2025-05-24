using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class CsaMDashBoard3
{
    public long DashboardId { get; set; }

    public int TotalStudents { get; set; }

    public int TotalStaff { get; set; }

    public int Smsbalance { get; set; }

    public string PartnerName { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public DateTime ProcessedDate { get; set; }

    public int BoysCount { get; set; }

    public int GirlsCount { get; set; }

    public int BoysEnrolled { get; set; }

    public int GirlsEnrolled { get; set; }

    public int StaffEnrolled { get; set; }

    public int? Partnerlogincount { get; set; }
}
