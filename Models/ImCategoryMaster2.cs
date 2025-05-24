using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImCategoryMaster2
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

    public virtual ICollection<ImBillingOrdersDetail2> ImBillingOrdersDetail2s { get; set; } = new List<ImBillingOrdersDetail2>();

    public virtual ICollection<ImGrndetail2> ImGrndetail2s { get; set; } = new List<ImGrndetail2>();

    public virtual ICollection<ImIndentDetail2> ImIndentDetail2s { get; set; } = new List<ImIndentDetail2>();

    public virtual ICollection<ImIssueItemDetail2> ImIssueItemDetail2s { get; set; } = new List<ImIssueItemDetail2>();

    public virtual ICollection<ImItemExistingStock2> ImItemExistingStock2s { get; set; } = new List<ImItemExistingStock2>();

    public virtual ICollection<ImItemmaster2> ImItemmaster2s { get; set; } = new List<ImItemmaster2>();

    public virtual ICollection<ImPurchaseOrderItem2> ImPurchaseOrderItem2s { get; set; } = new List<ImPurchaseOrderItem2>();
}
