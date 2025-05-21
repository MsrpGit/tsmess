using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPgrequest
{
    public long PgrequestId { get; set; }

    public long PgtransactionId { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string? ReturnUrl { get; set; }

    public string? ExtraFields { get; set; }

    public string? RequestType { get; set; }

    public string? RequestUrl { get; set; }

    public decimal Amt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
