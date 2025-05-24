using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTMobilereglog1
{
    public long Id { get; set; }

    public string? Userid { get; set; }

    public string? Deviceid { get; set; }

    public DateTime Registereddate { get; set; }
}
