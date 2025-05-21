using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImAsmassetTransaction
{
    public long Id { get; set; }

    public string AssetTransId { get; set; } = null!;

    public string AssetId { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public decimal? Amount { get; set; }

    public string AssignedTo { get; set; } = null!;

    public string? Department { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
