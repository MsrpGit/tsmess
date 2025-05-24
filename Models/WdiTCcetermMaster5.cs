using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTCcetermMaster5
{
    public int TermMasterId { get; set; }

    public string TermName { get; set; } = null!;

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public bool? Iscce { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }
}
