using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMMessageFolder2
{
    public long Fid { get; set; }

    public string Fname { get; set; } = null!;

    public string UserId { get; set; } = null!;
}
