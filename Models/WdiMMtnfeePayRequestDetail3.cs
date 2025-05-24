using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMMtnfeePayRequestDetail3
{
    public long MtnfeePayRequestDetailsId { get; set; }

    public long? MtnfeePayRequestIdFk { get; set; }

    public long? FeeHeadId { get; set; }

    public decimal? Amount { get; set; }

    public long? FeeDueId { get; set; }

    public string? AdminNo { get; set; }

    public long? AcademicYearId { get; set; }

    public long? PartnerId { get; set; }
}
