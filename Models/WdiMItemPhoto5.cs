using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMItemPhoto5
{
    public long PhotoId { get; set; }

    public long? ItemId { get; set; }

    public string? PhotoPath { get; set; }

    public string Title { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public bool IsSecondaryDocument { get; set; }

    public virtual WdiMItemDescription5? Item { get; set; }
}
