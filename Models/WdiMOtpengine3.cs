using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMOtpengine3
{
    public long RequestId { get; set; }

    public string Otp { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public byte Status { get; set; }

    public long PartnerId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
