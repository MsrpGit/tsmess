using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMClass4
{
    public int ClassId { get; set; }

    public string? ClassName { get; set; }

    public long? PartnerId { get; set; }

    /// <summary>
    /// 0: watch2learn classes; -1: partners CLasses; other numbers : mapped to watch2learn classes 
    /// </summary>
    public int W2lClassId { get; set; }

    public int TotalSeats { get; set; }

    public bool? IsCce { get; set; }
}
