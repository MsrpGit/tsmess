using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTDeleteLog1
{
    public long TransId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime DateOfOperation { get; set; }

    public string ObjectName { get; set; } = null!;
}
