using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImDepartmentMaster3
{
    public long Id { get; set; }

    public string DeptId { get; set; } = null!;

    public string DeptName { get; set; } = null!;

    public string HoduserId { get; set; } = null!;

    public string? Location { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public bool? Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }
}
