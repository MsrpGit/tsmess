using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTMedium1
{
    public int MediumId { get; set; }

    public string Medium { get; set; } = null!;

    public string MediumCode { get; set; } = null!;

    public bool? IsDefault { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public DateTime? CeatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
