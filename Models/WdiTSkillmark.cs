using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTSkillmark
{
    public int SkillMarksId { get; set; }

    public int? SkillId { get; set; }

    public string? UserId { get; set; }

    public int? SubjectId { get; set; }

    public int? ExaminationId { get; set; }

    public decimal? Marks { get; set; }

    public DateTime? EnteredDate { get; set; }

    public string? EnteredBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public long? SkillScheduleId { get; set; }

    public string? Remarks { get; set; }
}
