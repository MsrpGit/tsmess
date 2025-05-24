using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMIcsetool4
{
    public int ToolId { get; set; }

    public string? ToolName { get; set; }

    public bool? IsActive { get; set; }

    public long? PartnerId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
