using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncFeedBackQuery
{
    public long FbqueryId { get; set; }

    public string FbqueryCode { get; set; } = null!;

    public string FbqueryText { get; set; } = null!;

    public bool Status { get; set; }

    public long AcademicYearId { get; set; }
}
