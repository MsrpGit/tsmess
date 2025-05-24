using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTBranchRegister1
{
    public long BranchRegisterId { get; set; }

    public string RegisterCode { get; set; } = null!;

    public long RequestFrom { get; set; }

    public string RequestFromUser { get; set; } = null!;

    public string RequestFromBranchTitle { get; set; } = null!;

    public long RequestFromClassId { get; set; }

    public long RequestFromAcYearId { get; set; }

    public long RequestTo { get; set; }

    public string RequestToUser { get; set; } = null!;

    public string RequestToBranchTitle { get; set; } = null!;

    public long RequestToClassId { get; set; }

    public long RequestToAcYearId { get; set; }

    /// <summary>
    /// 1 means Inward , 2 means Outward
    /// </summary>
    public bool InwardOrOutward { get; set; }

    public string RequestMode { get; set; } = null!;

    public string RequestStatus { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public string? RequestInfo { get; set; }

    public string? AdditionalInfo { get; set; }

    public string RequestRaisedBy { get; set; } = null!;

    public string? RequestApprovedBy { get; set; }

    public DateTime? RequestApprovedDate { get; set; }

    public bool IsActive { get; set; }

    public string? AllotedAdmissionNo { get; set; }

    public string? AllotedUserId { get; set; }

    public string RequestType { get; set; } = null!;
}
