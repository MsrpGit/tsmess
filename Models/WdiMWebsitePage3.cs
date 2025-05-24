using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMWebsitePage3
{
    public int WebsiteId { get; set; }

    public int? PageId { get; set; }

    public string? DateCreated { get; set; }

    public string? PageContent { get; set; }

    public long WebsitePageId { get; set; }

    public int Sequencenumber { get; set; }

    public string Custompagename { get; set; } = null!;

    public string? ShortText { get; set; }
}
