using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPaytmpgplusresponse3
{
    public long Id { get; set; }

    public string ItemId { get; set; } = null!;

    public string EnrollNo { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string OrderId { get; set; } = null!;

    public decimal Amount { get; set; }

    public long FeeDueId { get; set; }

    public long FeeHeadId { get; set; }

    public string? PaytmInfo { get; set; }

    public bool IsActive { get; set; }

    public string? PaytmLog { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
