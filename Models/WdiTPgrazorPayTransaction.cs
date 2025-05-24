using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPgrazorPayTransaction
{
    public long Id { get; set; }

    public string MerchantTransactionId { get; set; } = null!;

    public string RazorpayOrderId { get; set; } = null!;

    public string Razorpaypaymentid { get; set; } = null!;

    public string RazorpaySignature { get; set; } = null!;

    public decimal TransAmount { get; set; }

    public string TransStatus { get; set; } = null!;

    public DateTime TransTimestamp { get; set; }

    public string? TransResponse { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
