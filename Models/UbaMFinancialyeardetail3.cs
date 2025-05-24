using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UbaMFinancialyeardetail3
{
    public long UcbfinancialYearId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public bool IsCurrent { get; set; }

    public string AuditStatus { get; set; } = null!;

    public string? AuditBy { get; set; }

    public DateTime? AuditDate { get; set; }

    public DateTime? FyaccountClousureDate { get; set; }

    public string? FinancialAccountsStatus { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
