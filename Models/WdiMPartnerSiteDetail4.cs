using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMPartnerSiteDetail4
{
    public int WebsiteId { get; set; }

    public long PartnerId { get; set; }

    public string? WebsiteTitle { get; set; }

    public string? WebsiteCaption { get; set; }

    public string? WebsiteShortName { get; set; }

    public string? WebsiteLogo { get; set; }

    /// <summary>
    /// 0 : InActive  ,  1 : Active.
    /// </summary>
    public bool? Status { get; set; }

    public string? WebsiteAddress { get; set; }

    public short? TemplateId { get; set; }

    public string? ContactNumber { get; set; }

    public long IsMainBranch { get; set; }

    public string WebsiteCss { get; set; } = null!;

    public short ServicesProvided { get; set; }

    public string SiteUrls { get; set; } = null!;

    public string WebSiteHeaderLogo { get; set; } = null!;

    public string? Keywords { get; set; }

    public string? Description { get; set; }

    public string? Title { get; set; }

    public string Mobile { get; set; } = null!;

    public string? ListOfModules { get; set; }

    public long? ValidityPeriod { get; set; }

    public long IsSubBranch { get; set; }
}
