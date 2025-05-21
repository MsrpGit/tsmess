using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcsetoolMapping
{
    public long ToolMappingId { get; set; }

    public int? ToolId { get; set; }

    public int? ClassId { get; set; }

    public int? SectionId { get; set; }

    public int? SubjectId { get; set; }

    public long? ExaminationId { get; set; }

    public long? ScheduleId { get; set; }

    public int? MaxMarks { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsSubTool { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
