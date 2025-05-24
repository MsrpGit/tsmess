using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class CsaTVideoMetri5
{
    public long Id { get; set; }

    public string FileId { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public string ViewedBy { get; set; } = null!;

    public DateTime ViewedDate { get; set; }

    /// <summary>
    /// If viewed same video same day multiple times then increment view count else add new entry
    /// </summary>
    public int ViewCount { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// By Deafult false , Once Service sync done will be changed to true
    /// </summary>
    public bool SyncStatus { get; set; }

    public DateTime? SyncDate { get; set; }
}
