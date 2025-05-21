using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMPaymentExtraDetail
{
    public int Id { get; set; }

    public long PaymentId { get; set; }

    /// <summary>
    /// MID Number
    /// </summary>
    public string? BatchNo { get; set; }

    /// <summary>
    /// RR Number
    /// </summary>
    public string? ReferenceNo { get; set; }

    /// <summary>
    /// Card and cheque and DD number
    /// </summary>
    public string? CardAndCheckAndDdno { get; set; }

    public DateTime? Date { get; set; }

    public string? BankName { get; set; }

    public decimal? Amount { get; set; }

    public string? BankNarration { get; set; }

    public string? Type { get; set; }

    public string? ProceedingNumber { get; set; }

    public DateTime? DateOfCredit { get; set; }

    public string Status { get; set; } = null!;

    public string? BankType { get; set; }
}
