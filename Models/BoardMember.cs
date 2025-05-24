using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class BoardMember
{
    public int Id { get; set; }

    public string EmpName { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string? ProfileImgPath { get; set; }

    public bool Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }
}
