using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMClassWiseStypendAmount
{
    public int Id { get; set; }

    public long Classid { get; set; }

    public long? SectionId { get; set; }

    public long ScholarshipId { get; set; }

    public decimal? Amount { get; set; }

    public long? Partnerid { get; set; }

    public long? AcademicyearId { get; set; }

    public string? Createdby { get; set; }

    public DateOnly? Createddate { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifieddate { get; set; }
}
