using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMFeeHeadMaster6
{
    public long FeeHeadId { get; set; }

    public string? FeeHeadName { get; set; }

    public short GroupId { get; set; }

    public string? PaymentType { get; set; }

    public int? ClassId { get; set; }

    public decimal? Amount { get; set; }

    public bool? Status { get; set; }

    public long? PartnerId { get; set; }

    /// <summary>
    /// I - Individual, G - Group
    /// </summary>
    public string? FeeType { get; set; }

    public bool? IsRefundable { get; set; }

    /// <summary>
    /// This has the value &apos;old&apos; or &apos;new&apos;
    /// </summary>
    public string? TypeOfStudent { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long AcademicYearId { get; set; }

    public bool? IsConcessionable { get; set; }

    public double? ConcessionablePercent { get; set; }

    public string? SchoolType { get; set; }

    public string? FriendlyName { get; set; }

    public string? MappingName { get; set; }

    public decimal? FineAmount { get; set; }

    public int ScholarshipId { get; set; }

    public bool? Iscustomized { get; set; }

    public string? HeadPrefix { get; set; }

    public bool IsFixed { get; set; }

    /// <summary>
    /// REGULAR, ACKNOWLEDGEMENT
    /// </summary>
    public string ReceiptType { get; set; } = null!;

    public long SectionId { get; set; }

    public long Pgmid { get; set; }

    public DateTime? DueDate { get; set; }

    public long TaxConfigMid { get; set; }

    public string TaxInclorExcl { get; set; } = null!;

    public string FeeReceiptLogo { get; set; } = null!;

    public long M2mregTypeId { get; set; }

    public bool IsSecondaryFee { get; set; }
}
