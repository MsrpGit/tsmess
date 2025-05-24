using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentCoScholasticMark4
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int? PartnerDescriptorId { get; set; }

    public decimal? SecuredMarks { get; set; }

    public string? Grade { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public int ClassId { get; set; }

    public long SectionId { get; set; }

    public long TermorExamId { get; set; }
}
