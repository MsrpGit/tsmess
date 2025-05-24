using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTicketStatus4
{
    public int StatusId { get; set; }

    public string? StatusName { get; set; }

    public virtual ICollection<WdiMTicket4> WdiMTicket4s { get; set; } = new List<WdiMTicket4>();
}
