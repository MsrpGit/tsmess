using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTicketType
{
    public int TicketTypeId { get; set; }

    public string? TicketTypeName { get; set; }

    public virtual ICollection<WdiMTicket> WdiMTickets { get; set; } = new List<WdiMTicket>();
}
