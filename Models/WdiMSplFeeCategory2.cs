using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSplFeeCategory2
{
    public int FeeCategoryId { get; set; }

    public string FeeCategoryName { get; set; } = null!;

    public long AcademicYearId { get; set; }

    public long PartnerId { get; set; }

    /// <summary>
    /// False - Deleted, True - Active.
    /// </summary>
    public bool Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;
}
