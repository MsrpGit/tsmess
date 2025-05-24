using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMBillingOrder4
{
    public long BillId { get; set; }

    public string UserId { get; set; } = null!;

    public string? UserType { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? BillDate { get; set; }

    public bool? RepeatCartDate { get; set; }

    public long DepartmentId { get; set; }

    public string? BillingType { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ICollection<WdiMBillingOrdersDetail4> WdiMBillingOrdersDetail4s { get; set; } = new List<WdiMBillingOrdersDetail4>();
}
