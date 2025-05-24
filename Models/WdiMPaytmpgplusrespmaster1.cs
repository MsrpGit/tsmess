using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMPaytmpgplusrespmaster1
{
    public long Id { get; set; }

    public string OrderId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public decimal Amount { get; set; }

    public string OrderStatus { get; set; } = null!;

    public bool IsProcessed { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
