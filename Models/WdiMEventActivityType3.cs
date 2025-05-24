using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMEventActivityType3
{
    public long EventActivityTypeId { get; set; }

    public string? EventActivityName { get; set; }

    public long PartnerId { get; set; }

    public DateTime? CreatedDate { get; set; }
}
