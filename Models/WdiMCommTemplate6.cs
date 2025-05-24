using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMCommTemplate6
{
    public long CommTemplateId { get; set; }

    public long PartnerTemplateId { get; set; }

    /// <summary>
    /// NULL - Immediately, Date - Consider on which Date Mail,SMS should be send.
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// P - Pending, C - Completed, F - Failed
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// E - Email , S - SMS
    /// </summary>
    public string TemplateType { get; set; } = null!;

    public string? Action { get; set; }

    public string? PartnerEmailId { get; set; }

    public string? Subject { get; set; }

    public string? EmailTemplateText { get; set; }

    public string? SenderInfo { get; set; }

    public string? SmstemplateText { get; set; }

    public string? TemplateParams { get; set; }

    public string XmlfileName { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcadamicYearId { get; set; }

    public string? SendingType { get; set; }

    public string? Days { get; set; }

    /// <summary>
    /// 0 - false(Not Active)  1 - True(Active)
    /// </summary>
    public bool? IsApproved { get; set; }

    public bool? IsTestTemplateSend { get; set; }

    public bool? IsNoted { get; set; }

    public DateTime CreatedDate { get; set; }
}
