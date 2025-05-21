using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImStaffItemsRequest
{
    public long Id { get; set; }

    public string RequestId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? UserType { get; set; }

    public string StoreId { get; set; } = null!;

    public decimal? Amount { get; set; }

    public DateTime? RequestedDate { get; set; }

    public bool? RepeatCartDate { get; set; }

    public long DepartmentId { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }
}
