using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncInventoryworkflowMaster
{
    public long InvWfmid { get; set; }

    public long? RefWorkflowTransId { get; set; }

    public string RefMasterId { get; set; } = null!;

    public string InvType { get; set; } = null!;

    public string Remarks { get; set; } = null!;

    public bool Status { get; set; }

    public long PartnerId { get; set; }

    public long AcademicyearId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
