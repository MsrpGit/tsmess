using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTUserQuery4
{
    public long QueryId { get; set; }

    public string UserId { get; set; } = null!;

    public string QueryDetails { get; set; } = null!;

    public string? EmailId { get; set; }

    public long AcademicYearId { get; set; }

    public byte[]? EncryptedEmailId { get; set; }
}
