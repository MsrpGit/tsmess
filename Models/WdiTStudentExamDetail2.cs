using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentExamDetail2
{
    public long Id { get; set; }

    public long ExamId { get; set; }

    public string UserId { get; set; } = null!;

    public int TeacherRemarksId { get; set; }

    public int PrinicipalRemarksId { get; set; }

    public bool ResultsPublished { get; set; }

    public long AcademicYearId { get; set; }
}
