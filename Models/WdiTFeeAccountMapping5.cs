using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTFeeAccountMapping5
{
    public long FeeAccountId { get; set; }

    public string? MappingName { get; set; }

    public long? CrHeadId { get; set; }

    public long? DrHeadId { get; set; }

    public long? AcademicyearId { get; set; }

    public long? PartnerId { get; set; }

    public decimal? Percentage { get; set; }

    public long OrganizationId { get; set; }

    public decimal? TotalPercentage { get; set; }
}
