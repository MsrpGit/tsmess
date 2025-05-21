using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImKitMaster
{
    public long Id { get; set; }

    public string KitId { get; set; } = null!;

    public string? KitName { get; set; }

    public long DepartmentId { get; set; }

    public string? Status { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ICollection<ImKitItemDetail> ImKitItemDetails { get; set; } = new List<ImKitItemDetail>();
}
