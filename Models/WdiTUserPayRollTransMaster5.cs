using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTUserPayRollTransMaster5
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Month { get; set; } = null!;

    public decimal GrossSalary { get; set; }

    public decimal? Lopdays { get; set; }

    public decimal Lopamount { get; set; }

    public decimal NetSalary { get; set; }

    public string? Remarks { get; set; }

    public long? AcadamicYearId { get; set; }

    public byte Isprocessed { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public decimal LateDeductionAmt { get; set; }
}
