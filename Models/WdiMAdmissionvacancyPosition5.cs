using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAdmissionvacancyPosition5
{
    public int Id { get; set; }

    public int? Classid { get; set; }

    public int? Totalseats { get; set; }

    public long? Academicid { get; set; }

    public long? Patnerid { get; set; }

    public int? Seatsforacyr { get; set; }

    public string? Createdby { get; set; }

    public DateOnly? Createddate { get; set; }

    public string? ForAcyr { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public long SectionId { get; set; }

    public string Category { get; set; } = null!;
}
