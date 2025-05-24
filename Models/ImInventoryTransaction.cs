using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImInventoryTransaction
{
    public int Id { get; set; }

    public int ItemId { get; set; }

    public int QuantityPresent { get; set; }

    public int VendorId { get; set; }

    public DateTime ReceivedDate { get; set; }

    public int QuantityReceived { get; set; }

    public DateTime ExpiryDate { get; set; }

    public bool NoAdulteration { get; set; }

    public bool NoFoulSmell { get; set; }

    public bool NoInsects { get; set; }

    public bool NoTampering { get; set; }

    public bool NotCleanlyPacked { get; set; }

    public string? Remarks { get; set; }
}
