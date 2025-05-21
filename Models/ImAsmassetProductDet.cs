using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImAsmassetProductDet
{
    public long Id { get; set; }

    public string ProductId { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public long ProductCatgoryId { get; set; }

    public string ProductType { get; set; } = null!;

    public string? Manufacture { get; set; }

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public long PartnerId { get; set; }

    public long AcademicyearId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
