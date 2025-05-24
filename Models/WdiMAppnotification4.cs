using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAppnotification4
{
    public long AppNotificationId { get; set; }

    public long PartnerTemplateId { get; set; }

    public string NotificationAction { get; set; } = null!;

    public string TemplateText { get; set; } = null!;

    public string TemplateParams { get; set; } = null!;

    public string TemplateValues { get; set; } = null!;

    public string? UserId { get; set; }

    public long PartnerId { get; set; }

    public long AcademicyearId { get; set; }

    public DateTime NotifyOn { get; set; }

    /// <summary>
    /// 0 --- Un Read ;  1  --- Read
    /// </summary>
    public bool NotificationSyncStatus { get; set; }

    public DateTime? NotificationSyncDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string? Remarks { get; set; }
}
