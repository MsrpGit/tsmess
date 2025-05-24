using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMBusinessRuleMaster3
{
    public long BusinessRuleId { get; set; }

    public string BusinessRulename { get; set; } = null!;

    /// <summary>
    /// S-Single; R-Range
    /// </summary>
    public string BusinessRuleValueType { get; set; } = null!;

    public string BusinessRuleDataType { get; set; } = null!;

    public string? BusinessRuleFriendlyName { get; set; }

    public string? DefaultRuleValue { get; set; }

    public string BusinessRuleType { get; set; } = null!;

    public long FinancialYearId { get; set; }
}
