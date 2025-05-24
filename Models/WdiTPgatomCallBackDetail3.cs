using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPgatomCallBackDetail3
{
    public long Id { get; set; }

    public string? MerchantId { get; set; }

    public string? MerchantTxnId { get; set; }

    public decimal? Amt { get; set; }

    public string? Verified { get; set; }

    public string? Bid { get; set; }

    public string? BankName { get; set; }

    public string? AtomTxnId { get; set; }

    public string? Discriminator { get; set; }

    public decimal? Surcharge { get; set; }

    public string? CardNumber { get; set; }

    public string? TxnDate { get; set; }

    public string? CustomerAccNo { get; set; }

    public string? Clientcode { get; set; }
}
