using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMMultiBranchAccess1
{
    public long AccessId { get; set; }

    public string? UserId { get; set; }

    public long PartnerId { get; set; }

    public bool Add { get; set; }

    public bool Modify { get; set; }

    public bool Delete { get; set; }

    public bool View { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ModifiedDate { get; set; }
}
