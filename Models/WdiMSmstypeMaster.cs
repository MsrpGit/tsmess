using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSmstypeMaster
{
    public int SmsTypeId { get; set; }

    public string? SmsTypeTitle { get; set; }

    public string? SmsTypeDescription { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }
}
