using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMDocument2
{
    public long DocumentId { get; set; }

    public string DocumentName { get; set; } = null!;

    public string? Description { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// 0---Student Documents  1--Staff Document
    /// </summary>
    public int? Type { get; set; }
}
