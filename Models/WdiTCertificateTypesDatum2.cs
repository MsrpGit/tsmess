using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTCertificateTypesDatum2
{
    public long Id { get; set; }

    public string? Ctid { get; set; }

    public string UserId { get; set; } = null!;

    public int Class { get; set; }

    public int? Section { get; set; }

    public long? AcademicYearId { get; set; }

    public string? SerialNo { get; set; }

    public string? CertificateType { get; set; }

    public string? Studentfailed { get; set; }

    public string? Duestatus { get; set; }

    public string? ConcessionAvailed { get; set; }

    public string? Ncccadet { get; set; }

    public string? Conductness { get; set; }

    public string? DateofApp { get; set; }

    public string? DateofIssue { get; set; }

    public string? Reason { get; set; }

    public string? Remarks { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Profilestatus { get; set; }

    public string? Extrafields { get; set; }
}
