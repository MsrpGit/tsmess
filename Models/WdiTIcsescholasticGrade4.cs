using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcsescholasticGrade4
{
    public int ScholasticGradeId { get; set; }

    public int? MinMarksPercentage { get; set; }

    public int? MaxMarksPercentage { get; set; }

    public string? Grade { get; set; }

    public int? GradePoint { get; set; }

    public int? IndicativePercentage { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    /// <summary>
    /// If Select All Classes default class id will be 0 . Otherwise whatever client selected class id will be saved.
    /// </summary>
    public int? ClassId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
