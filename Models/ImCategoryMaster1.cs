using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImCategoryMaster1
{
    public long Id { get; set; }

    public string CategoryId { get; set; } = null!;

    public string? CategoryName { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryType { get; set; }

    public bool Active { get; set; }

    public long ParentCategory { get; set; }

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public long DepartmentId { get; set; }

    public virtual ICollection<ImBillingOrdersDetail1> ImBillingOrdersDetail1s { get; set; } = new List<ImBillingOrdersDetail1>();

    public virtual ICollection<ImGrndetail1> ImGrndetail1s { get; set; } = new List<ImGrndetail1>();

    public virtual ICollection<ImIndentDetail1> ImIndentDetail1s { get; set; } = new List<ImIndentDetail1>();

    public virtual ICollection<ImIssueItemDetail1> ImIssueItemDetail1s { get; set; } = new List<ImIssueItemDetail1>();

    public virtual ICollection<ImItemExistingStock1> ImItemExistingStock1s { get; set; } = new List<ImItemExistingStock1>();

    public virtual ICollection<ImItemmaster1> ImItemmaster1s { get; set; } = new List<ImItemmaster1>();

    public virtual ICollection<ImPurchaseOrderItem1> ImPurchaseOrderItem1s { get; set; } = new List<ImPurchaseOrderItem1>();
}
