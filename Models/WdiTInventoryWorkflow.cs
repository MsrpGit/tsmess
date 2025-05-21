using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTInventoryWorkflow
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? PartnerId { get; set; }

    public int? AcademicYearId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
