using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTransactionLog2
{
    public long LogId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime LoginTime { get; set; }

    public DateTime? LogoutTime { get; set; }

    public string SessionId { get; set; } = null!;
}
