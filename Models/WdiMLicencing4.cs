using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMLicencing4
{
    public long LicenceId { get; set; }

    public string LicenceKey { get; set; } = null!;

    public DateTime LicenceExpires { get; set; }

    public string? MacAddress { get; set; }

    public long PartnerId { get; set; }

    public int? LicenceTerm { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? PreviousChecksum { get; set; }
}
