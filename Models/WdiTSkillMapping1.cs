using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTSkillMapping1
{
    public int SkillMappingId { get; set; }

    public int? SkillId { get; set; }

    public int? ClassId { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public DateTime? CreatedDate { get; set; }
}
