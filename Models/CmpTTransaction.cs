using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class CmpTTransaction
{
    /// <summary>
    /// Cloud Campus Pay Proxy Id
    /// </summary>
    public long Ccppid { get; set; }

    /// <summary>
    /// Master Token is checksum to be shared with payment gateway as transaction unique Id
    /// </summary>
    public string MasterToken { get; set; } = null!;

    /// <summary>
    /// Pay Proxy TransactionId  generated while validation process
    /// </summary>
    public long PptokenId { get; set; }

    public decimal Amount { get; set; }

    /// <summary>
    /// Mask the digits and show only last 4 digits
    /// </summary>
    public string Mmid { get; set; } = null!;

    public string AccRef { get; set; } = null!;

    /// <summary>
    /// Client Transaction Note for the Payment
    /// </summary>
    public string TransRefNote { get; set; } = null!;

    public string Ccpprequest { get; set; } = null!;

    public string? Ccppresponse { get; set; }

    public string? Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? MomtransactionId { get; set; }
}
