using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmsapplicationPayment
{
    public long Id { get; set; }

    public string? ReceiptNo { get; set; }

    public string? RmsuserId { get; set; }

    public DateTime? DateofPayment { get; set; }

    public string? ApplicationNo { get; set; }

    public decimal? Amount { get; set; }

    public string? BankName { get; set; }

    public string? Ifsccode { get; set; }

    public string? ReferenceNo { get; set; }

    public string? BranchName { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? TransactionRemarks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long AcademicYearId { get; set; }
}
