using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImUserTypeItemsLimit1
{
    public long Id { get; set; }

    public string? UserType { get; set; }

    public long? MaxLimit { get; set; }

    public long? DepartmentId { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }
}
