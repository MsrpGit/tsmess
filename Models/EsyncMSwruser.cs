using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncMSwruser
{
    public long Id { get; set; }

    public string? SwruserId { get; set; }

    public long? MobileNo { get; set; }

    public DateTime? CreatedDate { get; set; }
}
