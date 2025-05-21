using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmsjobPosition
{
    public long Id { get; set; }

    public string? PositionName { get; set; }

    public string? FriendlyName { get; set; }

    public byte? IsActive { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? MandatoryFeilds { get; set; }
}
