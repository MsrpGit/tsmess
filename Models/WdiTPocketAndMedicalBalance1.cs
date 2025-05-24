using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPocketAndMedicalBalance1
{
    public int PaymentId { get; set; }

    public string? UseId { get; set; }

    public string? ServiceType { get; set; }

    public string? PaymentType { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? TransactionDate { get; set; }

    public long AcademicYearId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string ModeOfPayment { get; set; } = null!;
}
