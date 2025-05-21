using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTaxConfigurationMaster
{
    public long TaxConfigMid { get; set; }

    public string? TaxConfigName { get; set; }

    public string? FriendlyName { get; set; }

    public string? Description { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
