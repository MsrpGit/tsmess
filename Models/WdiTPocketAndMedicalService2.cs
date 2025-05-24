using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPocketAndMedicalService2
{
    public int TransId { get; set; }

    public string? UseId { get; set; }

    public string? TranRefNo { get; set; }

    public string? ServiceType { get; set; }

    public string? PaymentType { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string Remarks { get; set; } = null!;

    public long AcademicYearId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Name { get; set; }

    public bool? Recstatus { get; set; }

    public string ModeOfPayment { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public decimal BankCharges { get; set; }

    public string ProceedNumber { get; set; } = null!;

    public DateTime CreditDate { get; set; }

    public DateTime ProceedDate { get; set; }
}
