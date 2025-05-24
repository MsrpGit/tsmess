using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class Table1
{
    public long HostelId { get; set; }

    public string HostelName { get; set; } = null!;

    /// <summary>
    /// Boys, Girls, Staff ..... etc
    /// </summary>
    public string HostelType { get; set; } = null!;

    public string Warden { get; set; } = null!;
}
