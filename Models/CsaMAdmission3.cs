using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class CsaMAdmission3
{
    public long AdmissionId { get; set; }

    public int Received { get; set; }

    public int Rejected { get; set; }

    /// <summary>
    /// 0 -Enquiries, 1 - Applications, 2 - Admissions, 4 - Vacancy Position 
    /// </summary>
    public byte AdmType { get; set; }

    public string PartnerName { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public DateTime ProcessedDate { get; set; }
}
