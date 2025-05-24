using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImIndentMaster4
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

    public string? DemandNote { get; set; }

    public string? Purpose { get; set; }

    public string? FileReferenceNo { get; set; }

    public string StaffReqId { get; set; } = null!;

    public virtual ICollection<ImIndentDetail4> ImIndentDetail4s { get; set; } = new List<ImIndentDetail4>();
}
