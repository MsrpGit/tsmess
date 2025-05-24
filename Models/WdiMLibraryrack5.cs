using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMLibraryrack5
{
    public long RackId { get; set; }

    public string RackName { get; set; } = null!;

    public long PartnerId { get; set; }

    public bool Active { get; set; }
}
