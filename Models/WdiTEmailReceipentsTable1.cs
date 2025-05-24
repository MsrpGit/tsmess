using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEmailReceipentsTable1
{
    public long ReceipentId { get; set; }

    public long SchedulerId { get; set; }

    public string EmailId { get; set; } = null!;
}
