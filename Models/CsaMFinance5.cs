using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class CsaMFinance5
{
    public long FinanceId { get; set; }

    public decimal TotalFee { get; set; }

    public decimal Concession { get; set; }

    public decimal FeeCollected { get; set; }

    public decimal FeeDue { get; set; }

    public decimal Expenses { get; set; }

    public decimal AcBalance { get; set; }

    public string PartnerName { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public DateTime ProcessedDate { get; set; }

    public decimal DailyFeeCollected { get; set; }

    public decimal DailyExpenses { get; set; }
}
