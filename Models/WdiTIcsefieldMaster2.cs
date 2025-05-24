using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcsefieldMaster2
{
    public int FieldId { get; set; }

    public string? ShortCode { get; set; }

    public string? FieldName { get; set; }

    public int? AreaId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
