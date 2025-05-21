using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPayrollLoansAdvance
{
    public int LoanId { get; set; }

    public string UserId { get; set; } = null!;

    public string? LoanType { get; set; }

    public decimal PrincipalAmount { get; set; }

    public decimal? InterestRate { get; set; }

    public decimal? InterestAmount { get; set; }

    public decimal TotalAmount { get; set; }

    public int NumberOfInstallments { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? LoanStatus { get; set; }

    public long PartnerId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
