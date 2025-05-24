using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMEmpLeaveMaster1
{
    public long LeaveId { get; set; }

    public long PartnerId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime LeaveFrom { get; set; }

    public DateTime LeaveTo { get; set; }

    public short Status { get; set; }

    public string LeaveSanctionAuth { get; set; } = null!;

    public short NoOfDaysApplied { get; set; }

    public short NoOfDaysApproved { get; set; }

    public string SanctionDates { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public long AcademicYearId { get; set; }
}
