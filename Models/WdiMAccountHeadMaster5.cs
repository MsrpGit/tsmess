using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAccountHeadMaster5
{
    public int AccHeadId { get; set; }

    public string? AccDescription { get; set; }

    public int? AccMainHeadGroup { get; set; }

    public decimal? OpeningBalance { get; set; }

    public string ObalType { get; set; } = null!;

    public DateTime? TranStartDate { get; set; }

    public bool Status { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long? AccNumber { get; set; }

    public string AcHeadType { get; set; } = null!;
}
