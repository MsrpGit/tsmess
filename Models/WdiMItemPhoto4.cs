using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMItemPhoto4
{
    public long PhotoId { get; set; }

    public long? ItemId { get; set; }

    public string? PhotoPath { get; set; }

    public virtual WdiMItemDescription4? Item { get; set; }
}
