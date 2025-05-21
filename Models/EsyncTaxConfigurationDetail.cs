using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTaxConfigurationDetail
{
    public long TaxId { get; set; }

    public long? TaxConfigMid { get; set; }

    public string? TaxName { get; set; }

    public decimal? TaxPercentage { get; set; }

    public decimal? TaxAmount { get; set; }

    public bool IsPercentage { get; set; }

    public decimal TaxApplicableforMinAmount { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Gstno { get; set; }
}
