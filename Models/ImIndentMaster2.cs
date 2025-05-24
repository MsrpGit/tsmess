using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImIndentMaster2
{
    public long Id { get; set; }

    public string IndentId { get; set; } = null!;

    public DateTime IndentDate { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? ApprovedBy { get; set; }

    public long DepartmentId { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ICollection<ImIndentDetail2> ImIndentDetail2s { get; set; } = new List<ImIndentDetail2>();
}
