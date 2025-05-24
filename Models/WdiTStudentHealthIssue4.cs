using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentHealthIssue4
{
    public long HealthIssueId { get; set; }

    public string HealthIssueTitle { get; set; } = null!;

    public string HealthIssueDescription { get; set; } = null!;

    public string HealthActiontaken { get; set; } = null!;

    public DateTime HealthIssueDate { get; set; }

    public string UserId { get; set; } = null!;

    public long AcademicYearId { get; set; }
}
