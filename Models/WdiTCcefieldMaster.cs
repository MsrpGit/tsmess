using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTCcefieldMaster
{
    public int FieldId { get; set; }

    public string? ShortCode { get; set; }

    public string? FieldName { get; set; }

    public int? AreaId { get; set; }
}
