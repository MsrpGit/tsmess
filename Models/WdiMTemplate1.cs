using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTemplate1
{
    public int TemplateId { get; set; }

    public string TemplateName { get; set; } = null!;

    public string EmailTemplateText { get; set; } = null!;

    public string SmstemplateText { get; set; } = null!;

    public string? TemplateColumns { get; set; }

    public string? RelatedTo { get; set; }

    /// <summary>
    /// 0 - General
    /// </summary>
    public byte? MessageType { get; set; }

    /// <summary>
    /// If TRUE then those records will be displayed in Central Location(SendEmailSMS Page).
    /// </summary>
    public bool? IsGeneral { get; set; }

    /// <summary>
    /// 0 - General(This should be for entire school), 1 - Staff, 2 - Student,3 - Not Related to Staff or Student
    /// </summary>
    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }
}
