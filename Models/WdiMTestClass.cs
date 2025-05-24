using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTestClass
{
    public int ClassId { get; set; }

    public string? ClassName { get; set; }

    public long? PartnerId { get; set; }

    public int W2lClassId { get; set; }

    public int TotalSeats { get; set; }

    public bool? IsCce { get; set; }
}
