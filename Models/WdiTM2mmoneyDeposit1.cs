using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTM2mmoneyDeposit1
{
    public int DepositId { get; set; }

    public string? SlipNumber { get; set; }

    public string? Billinggroup { get; set; }

    public string? DepositType { get; set; }

    public decimal? DepositedAmount { get; set; }

    public DateTime? DepositedDate { get; set; }

    public int? TotalCheques { get; set; }

    public int? TotalPdc { get; set; }

    public decimal? PreviousCollections { get; set; }

    public string? Remarks { get; set; }

    public int? AcadamicYearId { get; set; }

    public int? Partnerid { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
