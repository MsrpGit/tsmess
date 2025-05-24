using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTSupportQuery5
{
    public int Id { get; set; }

    public string SupportId { get; set; } = null!;

    public string PartnerName { get; set; } = null!;

    public long PartnerId { get; set; }

    public string? Subject { get; set; }

    public string Query { get; set; } = null!;

    public string? Response { get; set; }

    public DateTime DateOfContact { get; set; }

    public DateTime? DateOfReply { get; set; }

    public long? MobileNumber { get; set; }

    public string TypeofContact { get; set; } = null!;

    /// <summary>
    /// 1 - Pending, 2 - Process, 3 -  Complete, 4 - Rejected.
    /// </summary>
    public byte? Status { get; set; }

    public byte[]? EncryptedEmailId { get; set; }

    public byte[]? EncryptedMobileNo { get; set; }

    public string? Addquery { get; set; }
}
