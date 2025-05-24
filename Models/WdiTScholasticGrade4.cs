using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTScholasticGrade4
{
    public int ScholasticGradeId { get; set; }

    public int? MinMarksPercentage { get; set; }

    public int? MaxMarksPercentage { get; set; }

    public string? Grade { get; set; }

    public int? GradePoint { get; set; }

    public int? IndicativePercentage { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
