using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncMRmsnotification
{
    public long Id { get; set; }

    public string? NotificationId { get; set; }

    public string? NotificationNo { get; set; }

    public string NotificationSubject { get; set; } = null!;

    public decimal? ApplicationAmount { get; set; }

    public DateTime? ReleasedDate { get; set; }

    public DateTime? LastDateforApply { get; set; }

    public DateTime? LastDateforPayment { get; set; }

    public DateTime? LastDateforModifications { get; set; }

    public string? ResultsStaticUrl { get; set; }

    public string? ResultsDynamicUrl { get; set; }

    public DateTime? ResultsDate { get; set; }

    public string? WebNoteUrl { get; set; }

    public DateTime? ApplicationStartDate { get; set; }

    public DateTime? ApplicationEnddate { get; set; }

    public string NotificationStatus { get; set; } = null!;

    public byte Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string NotificationMode { get; set; } = null!;

    public int Type { get; set; }

    public string NotificationStage { get; set; } = null!;
}
