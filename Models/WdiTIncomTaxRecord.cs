using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIncomTaxRecord
{
    public int TaxId { get; set; }

    public string? TaxNo { get; set; }

    public string? UserId { get; set; }

    public string? StudentName { get; set; }

    public string? ClassName { get; set; }

    public string? ReceiptNo { get; set; }

    public long? FeeHeadId { get; set; }

    public string? FeeHeadName { get; set; }

    public decimal? PaidAmount { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
