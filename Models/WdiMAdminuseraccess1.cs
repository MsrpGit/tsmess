using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAdminuseraccess1
{
    public long Id { get; set; }

    public long PartnerId { get; set; }

    public int Usertype { get; set; }

    public string ModuleName { get; set; } = null!;

    public bool Access { get; set; }
}
