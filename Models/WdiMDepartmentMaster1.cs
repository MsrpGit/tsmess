using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMDepartmentMaster1
{
    public long DeptId { get; set; }

    public string DeptName { get; set; } = null!;

    public string HoduserId { get; set; } = null!;

    public string? Location { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public bool Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDefault { get; set; }
}
