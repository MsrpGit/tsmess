using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMFinancialYear5
{
    public long FinancialYearId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public long PartnerId { get; set; }

    public string? AuditBy { get; set; }

    public DateTime? AuditDate { get; set; }

    public string? AuditStatus { get; set; }

    public string? Createdby { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? FinancialAccountsStatus { get; set; }

    public DateTime? FyaccountClousureDate { get; set; }

    public bool IsCurrent { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long? UcbfinancialYearId { get; set; }
}
