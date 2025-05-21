using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncMRmsdocument
{
    public long DocumentId { get; set; }

    public string? DocumentName { get; set; }

    public string? Description { get; set; }

    public int? Type { get; set; }

    public byte IsActive { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int SequenceNo { get; set; }
}
