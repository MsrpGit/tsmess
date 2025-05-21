using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMHostel
{
    public long HostelId { get; set; }

    public string HostelName { get; set; } = null!;

    /// <summary>
    /// Boys, Girls, Staff ....  etc
    /// </summary>
    public string HostelType { get; set; } = null!;

    public string HostelWarden { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }
}
