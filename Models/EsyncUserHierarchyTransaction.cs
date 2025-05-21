using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncUserHierarchyTransaction
{
    public long WorkFlowTransId { get; set; }

    public long? RefTransId { get; set; }

    public long? WfahconfigId { get; set; }

    public long? WfahmasterId { get; set; }

    public string? UserId { get; set; }

    public string? ProcessedBy { get; set; }

    public string? Status { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? Remarks { get; set; }

    public long? AcademicYearId { get; set; }

    public long? PartnerId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string Actionfor { get; set; } = null!;
}
