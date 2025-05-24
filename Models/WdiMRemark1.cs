using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMRemark1
{
    public int RemarkId { get; set; }

    public long PartnerId { get; set; }

    public string? Remark { get; set; }

    public string? Type { get; set; }

    public string? RemarkCode { get; set; }
}
