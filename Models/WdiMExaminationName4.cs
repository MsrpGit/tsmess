using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMExaminationName4
{
    public long ExaminationId { get; set; }

    public string? ExaminationName { get; set; }

    public long PartnerId { get; set; }

    public string? ShortName { get; set; }
}
