using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIssuesFeedback5
{
    public long TicketId { get; set; }

    public string? Type { get; set; }

    public string? Details { get; set; }

    public string? DateofPosted { get; set; }

    public string? Postedby { get; set; }

    public string? Status { get; set; }

    public string? Emailid { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }
}
