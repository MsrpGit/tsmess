using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentHistoricalDet3
{
    public int Id { get; set; }

    /// <summary>
    /// Here PageType=0  --&gt; Equiry Data
    ///          PageType=1  --&gt;Application Data
    ///          PageType=0  --&gt; Admission Data
    /// </summary>
    public int? PageType { get; set; }

    public int? EnquiryId { get; set; }

    public int? ApplicationId { get; set; }

    public string? UserId { get; set; }

    public long? SchoolId { get; set; }

    public long AcademicYearId { get; set; }

    public string? PreviousInstituteDetails { get; set; }

    public string? SchoolAddress { get; set; }

    public string? StudentAddress { get; set; }
}
