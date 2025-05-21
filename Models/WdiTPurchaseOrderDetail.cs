using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPurchaseOrderDetail
{
    public long Id { get; set; }

    public string VoucherNo { get; set; } = null!;

    public long ItemId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public long? Supplierid { get; set; }
}
