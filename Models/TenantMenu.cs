using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class TenantMenu
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public string? MenuName { get; set; }

    public string? Url { get; set; }

    public long PartnerId { get; set; }

    public DateTime? CreatedOn { get; set; }
}
