using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTSupportQueriesBackUp
{
    public int Id { get; set; }

    public string SupportId { get; set; } = null!;

    public string PartnerName { get; set; } = null!;

    public long? PartnerId { get; set; }

    public string? EmailId { get; set; }

    public string? Subject { get; set; }

    public string? Query { get; set; }

    public string? Response { get; set; }

    public DateTime DateOfContact { get; set; }

    public DateTime? DateOfReply { get; set; }

    public long? MobileNumber { get; set; }

    public string? TypeofContact { get; set; }

    public byte? Status { get; set; }

    public string? SupportEmailId { get; set; }

    public long? SupportMobileNumber { get; set; }

    public string? SchoolName { get; set; }

    public string? Addquery { get; set; }
}
