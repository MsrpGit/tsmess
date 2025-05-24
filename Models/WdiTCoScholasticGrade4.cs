using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTCoScholasticGrade4
{
    public int CoScholasticGradeId { get; set; }

    public decimal? MinGradePoint { get; set; }

    public decimal? MaxGradePoint { get; set; }

    public string? Grade { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
