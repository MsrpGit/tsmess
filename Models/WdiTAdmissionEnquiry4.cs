using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTAdmissionEnquiry4
{
    public long EnquiryId { get; set; }

    public long VisitorId { get; set; }

    public string StudentName { get; set; } = null!;

    public byte PresentClass { get; set; }

    public byte AdmissionClass { get; set; }

    public string Medium { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string OtherEnquiryDetails { get; set; } = null!;

    public byte EnquiryStatus { get; set; }

    public DateTime EnquiryDate { get; set; }

    public string? RejectReason { get; set; }
}
