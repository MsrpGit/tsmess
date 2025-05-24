using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMItemPhoto1
{
    public long PhotoId { get; set; }

    public long? ItemId { get; set; }

    public string? PhotoPath { get; set; }

    public virtual WdiMItemDescription1? Item { get; set; }
}
