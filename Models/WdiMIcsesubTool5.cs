using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMIcsesubTool5
{
    public int SubToolId { get; set; }

    public int ToolId { get; set; }

    public string? SubToolName { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
