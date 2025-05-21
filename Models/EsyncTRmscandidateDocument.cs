using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmscandidateDocument
{
    public long Id { get; set; }

    public string RmsuserId { get; set; } = null!;

    public long? DocumentId { get; set; }

    public string? DocumentFileName { get; set; }

    public string? DocumentRefNo { get; set; }

    public string? FileType { get; set; }

    public byte IsActive { get; set; }

    public string? Remarks { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
