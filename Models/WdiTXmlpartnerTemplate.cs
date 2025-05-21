using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTXmlpartnerTemplate
{
    public long XmltemplateId { get; set; }

    public long PartnerTemplateId { get; set; }

    public int TemplateId { get; set; }

    public string XmltemplateName { get; set; } = null!;

    /// <summary>
    /// 0 - false(Not Active)  1 - True(Active)
    /// </summary>
    public bool Status { get; set; }

    /// <summary>
    ///  0 - Not Approved, 1 - Approved
    /// </summary>
    public bool IsApproved { get; set; }

    public DateTime CreatedDate { get; set; }
}
