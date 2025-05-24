using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTicketType3
{
    public int TicketTypeId { get; set; }

    public string? TicketTypeName { get; set; }

    public virtual ICollection<WdiMTicket3> WdiMTicket3s { get; set; } = new List<WdiMTicket3>();
}
