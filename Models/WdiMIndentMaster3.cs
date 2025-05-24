using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMIndentMaster3
{
    public long IndentId { get; set; }

    public DateTime IndentDate { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public long DepartmentId { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ICollection<WdiMIndentItem3> WdiMIndentItem3s { get; set; } = new List<WdiMIndentItem3>();
}
