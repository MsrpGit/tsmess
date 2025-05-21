using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmsapplicationConcession
{
    public long Id { get; set; }

    public string? RmsuserId { get; set; }

    public DateTime? DateofPayment { get; set; }

    public string? ApplicationNo { get; set; }

    public decimal? ActualAmount { get; set; }

    public decimal? ConcessionAmount { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
