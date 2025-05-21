using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImIssueMaster
{
    public long Id { get; set; }

    public string IssueId { get; set; } = null!;

    public string IssuedTo { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? UserType { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? IssudeDate { get; set; }

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

    public string? ReceivedBy { get; set; }

    public string? DeliveryNo { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string IndentId { get; set; } = null!;

    public string ImprestRefNo { get; set; } = null!;

    public virtual ICollection<ImIssueItemDetail> ImIssueItemDetails { get; set; } = new List<ImIssueItemDetail>();
}
