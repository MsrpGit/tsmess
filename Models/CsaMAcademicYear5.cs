using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class CsaMAcademicYear5
{
    public long Csaid { get; set; }

    public long AcademicYearId { get; set; }

    public long PartnerId { get; set; }

    public bool IsCurrent { get; set; }
}
