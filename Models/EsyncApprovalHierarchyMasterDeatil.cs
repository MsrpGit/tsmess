using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncApprovalHierarchyMasterDeatil
{
    public long WfahmasterId { get; set; }

    public long? WfahconfigId { get; set; }

    public string? HierarchyName { get; set; }

    public bool IsRoleSpecific { get; set; }

    public string? AuthorisedPerson { get; set; }

    public long? SequenceNo { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
