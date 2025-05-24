using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UbaMM2mvoucherMaster2
{
    public long M2mtransId { get; set; }

    public string M2mvoucherNo { get; set; } = null!;

    public DateTime M2mvoucherDate { get; set; }

    public decimal M2mvoucherAmount { get; set; }

    public string M2mtransRefNo { get; set; } = null!;

    public string M2mnarration { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicyearId { get; set; }

    public long UcbfinancialYearId { get; set; }

    /// <summary>
    /// -2: Failed; -1: Pending; 0 : In Progress; 1: Completed
    /// </summary>
    public short SyncStatus { get; set; }

    public bool ActiveStatus { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
