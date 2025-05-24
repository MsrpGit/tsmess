using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTFacultyDetail4
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Classes { get; set; } = null!;

    public string Qualification { get; set; } = null!;

    public string? Experience { get; set; }

    public string? Achievements { get; set; }

    public string Subjects { get; set; } = null!;

    public DateTime DateOfJoin { get; set; }

    public long AcademicYearId { get; set; }

    public long? EnrollNo { get; set; }

    public string? ExtraFields { get; set; }

    public string? ProfessionalDetails { get; set; }

    public string? SpouseDetails { get; set; }

    public string? ReportingHead { get; set; }

    public string TeachingSections { get; set; } = null!;
}
