using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEmailSmsstatusTest
{
    public long EmailSmsid { get; set; }

    public long? CommTemplateId { get; set; }

    public string? UserId { get; set; }

    public string? EmailId { get; set; }

    public string? MobileNo { get; set; }

    public string? TemplateValues { get; set; }

    /// <summary>
    /// 0 - Pending, 1 - Success , -1 - Temporary Failed,-2 -   Temporary Failed, -3 - Permanent Failed
    /// </summary>
    public int EmailStatus { get; set; }

    /// <summary>
    /// 0 - Pending, 1 - Success , -1 - Temporary Failed,-2 -   Temporary Failed, -3 - Permanent Failed
    /// </summary>
    public int? Smsstatus { get; set; }

    public DateTime? Date { get; set; }
}
