using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPayRollAccountTransaction
{
    public long Id { get; set; }

    public string? PayTranId { get; set; }

    public long PayRollHeadId { get; set; }

    public decimal? Amount { get; set; }

    public string? Month { get; set; }

    public string? AcTransRefNo { get; set; }

    public string? Bank { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
