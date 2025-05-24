using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class Tempfeeconsd2
{
    public string? Userid { get; set; }

    public string? StudentName { get; set; }

    public string? AdmissionNo { get; set; }

    public string? RollNo { get; set; }

    public int? ClassId { get; set; }

    public string? ClassName { get; set; }

    public int? SectionId { get; set; }

    public string? SectionName { get; set; }

    public string? FeeHeadName { get; set; }

    public string? MobileNo { get; set; }

    public string? StudentType { get; set; }

    public decimal? ActualAmount { get; set; }

    public decimal? ConcessionAmount { get; set; }

    public decimal? AfterConcession { get; set; }

    public decimal? AmountPaid { get; set; }

    public decimal? AmountDue { get; set; }
}
