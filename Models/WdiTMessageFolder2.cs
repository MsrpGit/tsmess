using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTMessageFolder2
{
    public int Id { get; set; }

    public long MsgId { get; set; }

    public long Fid { get; set; }

    public string? UserId { get; set; }
}
