using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMObjestsmaster
{
    public int ObjectId { get; set; }

    public string ObjectName { get; set; } = null!;

    public string ObjectDescription { get; set; } = null!;

    public bool Status { get; set; }

    public int ObjectGroupId { get; set; }

    public int? ObjectModuleId { get; set; }

    public string SystemVersion { get; set; } = null!;

    public int LvobjectId { get; set; }
}
