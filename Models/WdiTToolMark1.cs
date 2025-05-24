using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTToolMark1
{
    public long ToolMarksId { get; set; }

    public long? ToolMappingId { get; set; }

    public string? UserId { get; set; }

    public int? SubjectId { get; set; }

    public int? SectionId { get; set; }

    public decimal? Marks { get; set; }

    public DateTime? EnteredDate { get; set; }

    public string? EnteredBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
