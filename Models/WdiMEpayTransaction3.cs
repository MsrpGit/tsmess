using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMEpayTransaction3
{
    public int Id { get; set; }

    public long? Amount { get; set; }

    public string? Guid { get; set; }

    public string? Uid { get; set; }

    public DateOnly? CeatedDate { get; set; }

    public long? PartnerId { get; set; }
}
