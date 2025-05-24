using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMQualification2
{
    public int QualificationId { get; set; }

    public string? Qualification { get; set; }

    public long? PartnerId { get; set; }
}
