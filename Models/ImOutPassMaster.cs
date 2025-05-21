using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImOutPassMaster
{
    public long Id { get; set; }

    public string OutPassId { get; set; } = null!;

    public DateTime Date { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? ApprovedBy { get; set; }

    public string? VehicleNumber { get; set; }

    public string? StaffName { get; set; }

    public string? OutpassReason { get; set; }

    public long DepartmentId { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ICollection<ImOutPassDetail> ImOutPassDetails { get; set; } = new List<ImOutPassDetail>();
}
