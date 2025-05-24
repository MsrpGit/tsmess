using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class Product
{
    public int? ProductId { get; set; }

    public string? Name { get; set; }

    public string? Discrption { get; set; }

    public string? Address { get; set; }
}
