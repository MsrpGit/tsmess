using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEmailReceipentsTable3
{
    public long ReceipentId { get; set; }

    public long SchedulerId { get; set; }

    public string EmailId { get; set; } = null!;
}
