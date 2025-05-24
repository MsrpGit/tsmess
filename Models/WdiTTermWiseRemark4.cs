using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTermWiseRemark4
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public long AcademicYearId { get; set; }

    public string? ScholasticT1remarks { get; set; }

    public string? ScholasticT2remarks { get; set; }

    public string? CoScholasticT1remarks { get; set; }

    public string? CoScholasticT2remarks { get; set; }
}
