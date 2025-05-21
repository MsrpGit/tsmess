using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncApprovalHierarchyMaster
{
    public long WfahconfigId { get; set; }

    public string? Wfname { get; set; }

    public string? Description { get; set; }

    public long? ReferenceId { get; set; }

    public string? Type { get; set; }

    public long? AcademicYearId { get; set; }

    public long? PartnerId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
