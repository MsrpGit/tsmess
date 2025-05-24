using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPgtransaction4
{
    public long PgtransactionId { get; set; }

    public long PartnerMerchantId { get; set; }

    public long AcademicYearId { get; set; }

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

    public int ApplicationNo { get; set; }

    public string Transsource { get; set; } = null!;
}
