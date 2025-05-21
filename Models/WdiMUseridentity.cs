using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMUseridentity
{
    public string UserId { get; set; } = null!;

    public string? EnrollNo { get; set; }

    public string? Rfid { get; set; }

    public string? Ssid { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
