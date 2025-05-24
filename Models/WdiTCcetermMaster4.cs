using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTCcetermMaster4
{
    public int TermMasterId { get; set; }

    public string TermName { get; set; } = null!;

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public bool? Iscce { get; set; }
}
