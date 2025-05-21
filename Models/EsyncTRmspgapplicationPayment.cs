using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmspgapplicationPayment
{
    public long Id { get; set; }

    public string PgreceiptNo { get; set; } = null!;

    public string? RmsuserId { get; set; }

    public DateTime? DateofPayment { get; set; }

    public string? ApplicationNo { get; set; }

    public decimal? Amount { get; set; }

    public string? BankName { get; set; }

    public string? Ifsccode { get; set; }

    public string? ReferenceNo { get; set; }

    public string? BranchName { get; set; }

    public string? Status { get; set; }

    public string? ActualGeneratedReceipt { get; set; }

    public string? Remarks { get; set; }

    public string? TransactionRemarks { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
