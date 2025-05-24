using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMBankDetail6
{
    public long AccNumber { get; set; }

    public long? PartnerId { get; set; }

    public string? BankDetails { get; set; }

    public string? Address { get; set; }

    public decimal? AccBalance { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long AcademicYearId { get; set; }

    public string? Ifsc { get; set; }

    public int BankId { get; set; }

    public bool Printonreports { get; set; }
}
