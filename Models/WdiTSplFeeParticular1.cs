using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTSplFeeParticular1
{
    public int FeeId { get; set; }

    public string FeeName { get; set; } = null!;

    public decimal Amount { get; set; }

    public int CategoryId { get; set; }

    public long AcademicYearId { get; set; }

    public long PartnerId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;
}
