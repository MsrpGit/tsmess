using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPgfeePaymentDetail3
{
    public long PaymentDetailsId { get; set; }

    public long? PaymentId { get; set; }

    public long? FeeDueId { get; set; }

    public decimal? PaidAmount { get; set; }

    public DateTime? LastPaidDate { get; set; }

    public long AcademicYearId { get; set; }
}
