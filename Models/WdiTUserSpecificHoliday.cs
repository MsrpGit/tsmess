using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTUserSpecificHoliday
{
    public long UserHolidayId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime HolidayDate { get; set; }

    public string? HolidayTitle { get; set; }

    public string Description { get; set; } = null!;

    public bool? Valid { get; set; }

    public long RoleHolidayId { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
