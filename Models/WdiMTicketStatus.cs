using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTicketStatus
{
    public int StatusId { get; set; }

    public string? StatusName { get; set; }

    public virtual ICollection<WdiMTicket> WdiMTickets { get; set; } = new List<WdiMTicket>();
}
