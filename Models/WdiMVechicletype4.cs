using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMVechicletype4
{
    public int Id { get; set; }

    public string VechicleType { get; set; } = null!;

    public bool Active { get; set; }
}
