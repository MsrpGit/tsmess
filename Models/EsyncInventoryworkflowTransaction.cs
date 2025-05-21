using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncInventoryworkflowTransaction
{
    public int InvWfTransId { get; set; }

    public long InvWfmid { get; set; }

    public string ItemId { get; set; } = null!;

    public string? CategoryId { get; set; }

    public decimal? RequestedStock { get; set; }

    public decimal? ModifiedStock { get; set; }

    public string? Units { get; set; }

    public decimal? ExpCost { get; set; }

    public decimal? Costprice { get; set; }

    public decimal? Mrpprice { get; set; }

    public string Remarks { get; set; } = null!;

    public DateTime? ManufacturingDate { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? Surcharge { get; set; }

    public decimal? Discount { get; set; }

    public decimal? AdditionalExp { get; set; }

    public decimal? Gst { get; set; }

    public long PartnerId { get; set; }

    public long AcademicyearId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
