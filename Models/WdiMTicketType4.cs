using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTicketType4
{
    public int TicketTypeId { get; set; }

    public string? TicketTypeName { get; set; }

    public virtual ICollection<WdiMTicket4> WdiMTicket4s { get; set; } = new List<WdiMTicket4>();
}
