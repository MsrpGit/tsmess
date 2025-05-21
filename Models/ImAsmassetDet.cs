using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImAsmassetDet
{
    public long Id { get; set; }

    public string AssetId { get; set; } = null!;

    public string AssetName { get; set; } = null!;

    public string AssetDescription { get; set; } = null!;

    public long ProductCatgoryId { get; set; }

    public string ProductType { get; set; } = null!;

    public long? Supplier { get; set; }

    public string AuthorizedPerson { get; set; } = null!;

    public string? SerialNo { get; set; }

    public decimal? Price { get; set; }

    public string? AssetLocation { get; set; }

    public string? PurchaseType { get; set; }

    public DateTime PurchaseDate { get; set; }

    public DateTime WarrantyExpiryDate { get; set; }

    public string? DepreciationPercentage { get; set; }

    public string? DepreciationFrequency { get; set; }

    public short? AssetLifeTime { get; set; }

    public DateTime? ProductSelfLifeExpiryDate { get; set; }

    public string AssetStatus { get; set; } = null!;

    public string? Remarks { get; set; }

    public string? SpecificationName { get; set; }

    public string? SpecifiactionValue { get; set; }

    public long? Grnid { get; set; }

    public long PartnerId { get; set; }

    public long AcademicyearId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
