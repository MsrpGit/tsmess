using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmsnotificationDet
{
    public long Id { get; set; }

    public string JobId { get; set; } = null!;

    public string? NotificationId { get; set; }

    public long? DepartmentId { get; set; }

    public string? DeptName { get; set; }

    public long? PositionId { get; set; }

    public string? PostJob { get; set; }

    public long CategoryUr { get; set; }

    public long CategoryObc { get; set; }

    public long CategoryBc { get; set; }

    public long CategorySc { get; set; }

    public long CategorySt { get; set; }

    public long CategoryEws { get; set; }

    public long SpecialCategory1 { get; set; }

    public long SpecialCategory2 { get; set; }

    public long SpecialCategory3 { get; set; }

    public long Total { get; set; }

    public decimal? Amount { get; set; }

    public string? MinimumQulification { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? DocFileName { get; set; }

    public string? CategoryType { get; set; }

    public string? PostTitle { get; set; }
}
