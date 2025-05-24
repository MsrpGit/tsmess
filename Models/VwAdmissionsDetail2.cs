using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class VwAdmissionsDetail2
{
    public long EnquiryNo { get; set; }

    public int? ApplicationNo { get; set; }

    public string? StudentName { get; set; }

    public DateTime Dob { get; set; }

    public string? Gender { get; set; }

    public string? Nationality { get; set; }

    public string Medium { get; set; } = null!;

    public string? MobileNo { get; set; }

    public DateOnly? DateofEnquiry { get; set; }

    public string? AdmissionYear { get; set; }

    public string? ClassName { get; set; }

    public string? ParentName { get; set; }

    public string? Relation { get; set; }

    public string? AdmissionType { get; set; }

    public decimal? ApplicationAmount { get; set; }

    public string? AppicationStatus { get; set; }

    public string? EnquiryStatus { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }
}
