using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTNonbranchfeepaydetail3
{
    public long NonBranchTransId { get; set; }

    public long FeeCollectedForBranchId { get; set; }

    public string FeeCollectedForBranchDetails { get; set; } = null!;

    public string FeeCollectedForStudentId { get; set; } = null!;

    public string FeeCollectedForStudentAdmNo { get; set; } = null!;

    public decimal FeeTotalCollected { get; set; }

    public string FeeDetails { get; set; } = null!;

    public string FeeCollectedBy { get; set; } = null!;

    public long FeeCollectedByBranchId { get; set; }

    public long FeeCollectedByBranchAcYearId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? StudnetDetails { get; set; }
}
