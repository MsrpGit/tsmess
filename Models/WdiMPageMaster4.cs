using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMPageMaster4
{
    public int PageId { get; set; }

    public string? PageName { get; set; }

    public string? PageType { get; set; }

    public string? PageContent { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? UpdatedBy { get; set; }

    public int? PartnerType { get; set; }

    public string DisplayPageName { get; set; } = null!;
}
