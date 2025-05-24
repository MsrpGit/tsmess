using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTAppldoc1
{
    public long UserDocId { get; set; }

    public string UserName { get; set; } = null!;

    public long ApplicationId { get; set; }

    public string? DocumentType { get; set; }

    public string? DocumentRefNo { get; set; }

    public string? DocumentFileName { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public bool IsActive { get; set; }

    public long PartnerId { get; set; }

    public string? Remarks { get; set; }

    public string? UserId { get; set; }

    public string? FileType { get; set; }
}
