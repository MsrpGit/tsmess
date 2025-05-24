using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTicketType5
{
    public int TicketTypeId { get; set; }

    public string? TicketTypeName { get; set; }

    public virtual ICollection<WdiMTicket5> WdiMTicket5s { get; set; } = new List<WdiMTicket5>();
}
