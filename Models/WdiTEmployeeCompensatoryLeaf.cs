using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEmployeeCompensatoryLeaf
{
    public long Id { get; set; }

    public string? UserId { get; set; }

    public int? LeaveTypeId { get; set; }

    public DateTime? DateofWork { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public DateTime? RequestedDate { get; set; }

    public string? RequestedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedBy { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string DaySegment { get; set; } = null!;
}
