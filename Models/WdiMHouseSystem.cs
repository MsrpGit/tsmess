using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMHouseSystem
{
    public int HouseId { get; set; }

    public string House { get; set; } = null!;

    public string Colour { get; set; } = null!;

    public string Emblem { get; set; } = null!;

    public string? Motto { get; set; }

    public long Partnerid { get; set; }
}
