using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTenantusertemplateaccess
{
    public long Id { get; set; }

    public long RoleId { get; set; }

    public string UserId { get; set; } = null!;

    public long PartnerId { get; set; }

    public string Templategroup { get; set; } = null!;

    public bool Channelvoicepermitted { get; set; }

    public bool Channeltextpermitted { get; set; }

    public bool Channelnotificationpermitted { get; set; }

    public bool Channelemailpermitted { get; set; }

    public bool Channelwhatsapppermitted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
