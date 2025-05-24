using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMItemPhoto3
{
    public long PhotoId { get; set; }

    public long? ItemId { get; set; }

    public string? PhotoPath { get; set; }

    public virtual WdiMItemDescription3? Item { get; set; }
}
