using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class OcStaffUrldetail
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string? Url1 { get; set; }

    public string? Url2 { get; set; }

    public string? Url3 { get; set; }

    public string? Url4 { get; set; }

    public string? Url5 { get; set; }

    public string? Url6 { get; set; }

    public long AcademicYearId { get; set; }

    public long PartnerId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
