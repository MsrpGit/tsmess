using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class MenuTable4
{
    public int MenuId { get; set; }

    public string Name { get; set; } = null!;

    public string? Url { get; set; }

    public int? ParentId { get; set; }

    public bool Publish { get; set; }

    public string Version { get; set; } = null!;

    public DateTime ReleaseDate { get; set; }

    public string? ReleaseNotes { get; set; }

    public string ReleasedBy { get; set; } = null!;

    public long? PartnerId { get; set; }

    public int PageId { get; set; }
}
