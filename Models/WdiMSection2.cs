using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSection2
{
    public long SectionId { get; set; }

    public long? ClassId { get; set; }

    public string? SectionName { get; set; }

    public string? OptingSemisters { get; set; }

    public string SectionCode { get; set; } = null!;
}
