using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTUserQuery
{
    public long QueryId { get; set; }

    public string UserId { get; set; } = null!;

    public string QueryDetails { get; set; } = null!;

    public string? EmailId { get; set; }

    public long AcademicYearId { get; set; }

    public byte[]? EncryptedEmailId { get; set; }

    public string Type { get; set; } = null!;

    public string? Name { get; set; }

    public byte[]? EncryptedMobileNo { get; set; }

    public string? Remarks { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
