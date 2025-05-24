using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTUniCampusPgtransaction
{
    public long PgtransactionId { get; set; }

    public long UniCampusMerchantId { get; set; }

    public string MerchantTransactionId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public decimal TransactionAmount { get; set; }

    public DateTime TransactionTimestamp { get; set; }

    public int PgstatusId { get; set; }

    public decimal? MerchantSurchargeAmount { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int TransactionNo { get; set; }

    public long PartnerId { get; set; }

    public string? NoOfUnits { get; set; }
}
