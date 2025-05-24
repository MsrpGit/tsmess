using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImBillingOrder4
{
    public long Id { get; set; }

    public string BillId { get; set; } = null!;

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

    public string BankName { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public string? ChequeDate { get; set; }

    public string RefernceNo { get; set; } = null!;

    public string BankCharges { get; set; } = null!;

    public string PaymentRemarks { get; set; } = null!;

    public string ImprestRefNo { get; set; } = null!;

    public virtual ICollection<ImBillingOrdersDetail4> ImBillingOrdersDetail4s { get; set; } = new List<ImBillingOrdersDetail4>();
}
