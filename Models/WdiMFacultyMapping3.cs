using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMFacultyMapping3
{
    public int FacultyMappingId { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public string FacultyId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string SectionId { get; set; } = null!;

    public string SubjectId { get; set; } = null!;

    public int PeriodCount { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsClassTeacher { get; set; }
}
