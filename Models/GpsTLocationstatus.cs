using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class GpsTLocationstatus
{
    public long Id { get; set; }

    public long LocationId { get; set; }

    public bool Pickupstatus { get; set; }

    public bool Dropstatus { get; set; }

    public DateTime Tripdate { get; set; }
}
