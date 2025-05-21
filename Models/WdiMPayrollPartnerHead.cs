using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMPayrollPartnerHead
{
    public long PayRolePartnerHeadId { get; set; }

    public long HeadId { get; set; }

    public long PartnerId { get; set; }

    public bool IsFixed { get; set; }

    public decimal? Percentage { get; set; }

    public short? SlNo { get; set; }

    public bool? Status { get; set; }

    public bool IsSalaryRange { get; set; }

    public string SelectedHeads { get; set; } = null!;

    public string? SalRangeHeads { get; set; }

    public long ProllTemplateId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int FormulaMultiplier { get; set; }
}
