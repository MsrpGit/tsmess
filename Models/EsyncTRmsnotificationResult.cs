using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmsnotificationResult
{
    public long Id { get; set; }

    public string? NotificationId { get; set; }

    public string? RmsuserId { get; set; }

    public string? Result { get; set; }

    public string? ResultInfo { get; set; }

    public string? ResultStatus { get; set; }

    public string? Remarks { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
