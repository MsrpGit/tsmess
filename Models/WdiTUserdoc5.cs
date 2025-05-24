using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTUserdoc5
{
    public long UserDocId { get; set; }

    public long DocumentId { get; set; }

    public string UserId { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public bool IsActive { get; set; }

    public long PartnerId { get; set; }

    public string? DocumentRefNo { get; set; }

    public DateTime? ReturnDate { get; set; }

    public string? Remarks { get; set; }
}
