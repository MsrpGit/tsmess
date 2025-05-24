using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcsetoolMark5
{
    public long ToolMarksId { get; set; }

    public long? ToolMappingId { get; set; }

    public string? UserId { get; set; }

    public int? SubjectId { get; set; }

    public int? SectionId { get; set; }

    public decimal? Marks { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
