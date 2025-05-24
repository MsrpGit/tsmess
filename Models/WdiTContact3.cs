using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTContact3
{
    public int ContactId { get; set; }

    public string ContactName { get; set; } = null!;

    public string? Email { get; set; }

    public string? Question { get; set; }

    public string? Response { get; set; }

    public DateTime? DateOfContact { get; set; }

    public DateTime? DateOfReply { get; set; }

    public long? MobileNumber { get; set; }

    public long? PartnerId { get; set; }

    public string TypeofContact { get; set; } = null!;

    /// <summary>
    /// 1 - Pending, 2 - Process, 3 -  Complete, 4 - Rejected.
    /// </summary>
    public byte Status { get; set; }

    public byte[]? EncryptedEmailId { get; set; }

    public byte[]? EncryptedMobile { get; set; }
}
