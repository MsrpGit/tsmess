using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAccesspermission3
{
    public long AccessId { get; set; }

    public int ObjectId { get; set; }

    public int RoleId { get; set; }

    public bool Add { get; set; }

    public bool Modify { get; set; }

    public bool Delete { get; set; }

    public bool View { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ModifiedDate { get; set; }
}
