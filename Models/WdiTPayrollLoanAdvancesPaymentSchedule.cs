using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPayrollLoanAdvancesPaymentSchedule
{
    public int ScheduleId { get; set; }

    public int LoanId { get; set; }

    public int InstallmentNumber { get; set; }

    public string InstallmentMonth { get; set; } = null!;

    public decimal PrincipalComponent { get; set; }

    public decimal InterestComponent { get; set; }

    public decimal InstallmentAmount { get; set; }

    public decimal? AmountPaid { get; set; }

    public decimal BalanceAmount { get; set; }

    public string? PaymentStatus { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
