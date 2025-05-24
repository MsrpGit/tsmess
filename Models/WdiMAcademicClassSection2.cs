using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAcademicClassSection2
{
    public long Id { get; set; }

    public long? SectionId { get; set; }

    public long? ClassId { get; set; }

    public long? AcademicYearId { get; set; }

    public long? PartnerId { get; set; }
}
