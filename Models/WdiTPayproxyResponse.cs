using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPayproxyResponse
{
    public long PgresponseId { get; set; }

    public long PgrequestId { get; set; }

    public string PgtxnStatusCode { get; set; } = null!;

    public string PgtxnMsg { get; set; } = null!;

    public string PgtxnErrMsg { get; set; } = null!;

    public string ClientRefNo { get; set; } = null!;

    public string PgtxnRefNo { get; set; } = null!;

    public string BankTxnRefNo { get; set; } = null!;

    public string? RequestToken { get; set; }

    public string? ExtraFields { get; set; }

    public decimal Amt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
