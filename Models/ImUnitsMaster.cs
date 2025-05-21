using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImUnitsMaster
{
    public long Id { get; set; }

    public string UnitName { get; set; } = null!;

    public bool Active { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }
}
