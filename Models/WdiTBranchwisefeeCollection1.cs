using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTBranchwisefeeCollection1
{
    public long Id { get; set; }

    public DateTime Date { get; set; }

    public decimal ClosingBalance { get; set; }

    public decimal TotalCollection { get; set; }

    public decimal OnlineCollection { get; set; }

    public decimal InternalTransfer { get; set; }

    public decimal NetCash { get; set; }

    public decimal BankDeposit { get; set; }

    public decimal Expenditure { get; set; }

    public decimal Balance { get; set; }

    public decimal TechnoCash { get; set; }

    public decimal CashBalance { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
