using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTFineAmountDetail3
{
    public long FineId { get; set; }

    public string? UserId { get; set; }

    public long? FeeDueId { get; set; }

    public decimal? FineAmount { get; set; }

    public decimal? FinePaid { get; set; }

    public decimal? FineConcesion { get; set; }

    public string? Finereceiptno { get; set; }

    public DateTime? Paiddate { get; set; }

    public string? Paidby { get; set; }

    public long AcademicYearId { get; set; }

    public long PartnerId { get; set; }

    public long? PaymentId { get; set; }

    public bool? Mappingstatus { get; set; }
}
