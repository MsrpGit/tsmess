using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UbaSsconcessionType
{
    public long Id { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }

    public string? Group { get; set; }

    public int? Order { get; set; }
}
