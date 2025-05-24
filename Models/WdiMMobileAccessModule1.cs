using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMMobileAccessModule1
{
    public int ModuleId { get; set; }

    public string? ModuleName { get; set; }

    public int RoleId { get; set; }

    public bool? IsModuleAccess { get; set; }

    public long? Partnerid { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
