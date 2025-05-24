using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTicketStatus5
{
    public int StatusId { get; set; }

    public string? StatusName { get; set; }

    public virtual ICollection<WdiMTicket5> WdiMTicket5s { get; set; } = new List<WdiMTicket5>();
}
