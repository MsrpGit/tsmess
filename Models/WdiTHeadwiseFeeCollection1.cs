using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTHeadwiseFeeCollection1
{
    public long Id { get; set; }

    public DateTime Date { get; set; }

    public string? FeeHeadName { get; set; }

    public decimal? Amount { get; set; }

    public string? ModeofPayment { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
