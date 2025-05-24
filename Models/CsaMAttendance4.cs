using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class CsaMAttendance4
{
    public long AttendanceId { get; set; }

    /// <summary>
    /// 0 - Student, 1 - Staff
    /// </summary>
    public byte TypeOfUser { get; set; }

    public int TotalUser { get; set; }

    public int Present { get; set; }

    public decimal Leave { get; set; }

    public string PartnerName { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public DateTime ProcessedDate { get; set; }

    public int MdmstudentPresent { get; set; }

    public int MorningPresentCount { get; set; }

    public int AfternoonPresentCount { get; set; }

    public int AbsentCountMoreThan3Days { get; set; }
}
