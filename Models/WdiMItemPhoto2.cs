using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMItemPhoto2
{
    public long PhotoId { get; set; }

    public long? ItemId { get; set; }

    public string? PhotoPath { get; set; }

    public virtual WdiMItemDescription2? Item { get; set; }
}
