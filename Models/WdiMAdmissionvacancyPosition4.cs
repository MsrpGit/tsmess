using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAdmissionvacancyPosition4
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
}
