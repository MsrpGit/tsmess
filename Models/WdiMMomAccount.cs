using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMMomAccount
{
    public int MomAccountId { get; set; }

    public long? PartnerId { get; set; }

    public string? Spid { get; set; }

    public string? Sppassword { get; set; }

    public string? ServiceId { get; set; }
}
