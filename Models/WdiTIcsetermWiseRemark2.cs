using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcsetermWiseRemark2
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public long AcademicYearId { get; set; }

    public string? ScholasticT1remarks { get; set; }

    public string? CoScholasticT1remarks { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public int? TermId { get; set; }
}
