using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSpecialEnquiry5
{
    public long Id { get; set; }

    public string? ParticipentName { get; set; }

    public int? Age { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? WhatsAppContact { get; set; }

    public string? PresentProfession { get; set; }

    public string? SourceOfInformation { get; set; }

    public string? ReasonForParticipating { get; set; }

    public decimal? FeeAmount { get; set; }

    public string? FeePaidStatus { get; set; }

    public string? Feepaidby { get; set; }

    public DateTime? FeePaidDate { get; set; }

    public bool? RecordStatus { get; set; }

    public long Academicyearid { get; set; }

    public string SsreceiptNo { get; set; } = null!;
}
