using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTCallBackDetail2
{
    public long CallBackId { get; set; }

    public string? RequestUrl { get; set; }

    public string? ResPonseUrl { get; set; }

    public string? ExtraFields { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public long? AcademicyearId { get; set; }

    public long? PartnerId { get; set; }
}
