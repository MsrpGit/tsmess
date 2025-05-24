using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class Order
{
    public string? Id { get; set; }

    public string? ProductId { get; set; }

    public decimal? Cost { get; set; }

    public DateTime? Placed { get; set; }

    public string? CustomerId { get; set; }

    public string? Status { get; set; }
}
