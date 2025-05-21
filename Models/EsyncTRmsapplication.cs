using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmsapplication
{
    public long Id { get; set; }

    public string? ApplicationNo { get; set; }

    public string? ApplicationUniqueId { get; set; }

    public string RmsuserId { get; set; } = null!;

    public string? NotificationId { get; set; }

    public string? JobId { get; set; }

    public string? AppliedPost { get; set; }

    public string? Department { get; set; }

    public decimal? ApplicationFeeAmount { get; set; }

    public string? ApplicationFeeStatus { get; set; }

    public string? AcknowledgementNo { get; set; }

    public string? ApplicationFeereceiptNo { get; set; }

    public string? RecordStatus { get; set; }

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ExtraFields { get; set; }
}
