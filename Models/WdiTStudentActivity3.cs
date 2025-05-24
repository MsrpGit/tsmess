using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentActivity3
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? Sports { get; set; }

    public string? Hobbies { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
