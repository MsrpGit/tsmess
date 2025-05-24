using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMVisitorLog3
{
    public long VisitorId { get; set; }

    public string VisitorName { get; set; } = null!;

    public string? EmailId { get; set; }

    public string Address { get; set; } = null!;

    public byte[]? EncryptedEmailId { get; set; }

    public byte[]? EncryptedMobileNo { get; set; }
}
