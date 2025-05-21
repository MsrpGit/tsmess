using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTemplateMark
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public long SubjectId { get; set; }

    public long ExamTemplateId { get; set; }

    public decimal InternalMarks { get; set; }

    public decimal ExternalMarks { get; set; }

    public decimal AssignmentMarks { get; set; }

    public decimal? Total { get; set; }

    public string? InternalMarksFormatted { get; set; }

    public string? ExternalmarksFormatted { get; set; }

    public string? AssignmentmarksFormatted { get; set; }

    public int SequenceNo { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int Languagetype { get; set; }

    public string Subresult { get; set; } = null!;
}
