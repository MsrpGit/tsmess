using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMDocument4
{
    public long DocumentId { get; set; }

    public string DocumentName { get; set; } = null!;

    public string? Description { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int? Type { get; set; }
}
