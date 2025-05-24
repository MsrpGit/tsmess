using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTicketStatus3
{
    public int StatusId { get; set; }

    public string? StatusName { get; set; }

    public virtual ICollection<WdiMTicket3> WdiMTicket3s { get; set; } = new List<WdiMTicket3>();
}
