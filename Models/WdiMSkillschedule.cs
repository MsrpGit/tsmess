using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSkillschedule
{
    public int SkillScheduleId { get; set; }

    public long? ScheduleId { get; set; }

    public int? SkillId { get; set; }

    public decimal? Marks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public int? SubjectId { get; set; }

    public int? SectionId { get; set; }
}
