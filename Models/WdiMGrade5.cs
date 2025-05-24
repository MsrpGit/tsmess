using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMGrade5
{
    public short Id { get; set; }

    public long? PartnerId { get; set; }

    public short MarksFrom { get; set; }

    public short MarksTo { get; set; }

    public string Grade { get; set; } = null!;

    public decimal? GradePoint { get; set; }

    public long AcademicYearId { get; set; }

    public bool? IsSecondLanguage { get; set; }

    public bool IsNonCourse { get; set; }

    /// <summary>
    /// If it is 0 it will be indicated for all classes , other wise it will be class 
    /// </summary>
    public int? ApplicableClassId { get; set; }
}
