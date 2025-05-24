using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSmslog4
{
    public long SmslogId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime SyncTime { get; set; }

    public string MobileNo { get; set; } = null!;

    public bool SentStatus { get; set; }

    public string RecipientRelation { get; set; } = null!;

    public string Smstype { get; set; } = null!;

    public string AttendanceType { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public long CommTemplateId { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public string? AdmissionNo { get; set; }

    public string? Name { get; set; }
}
