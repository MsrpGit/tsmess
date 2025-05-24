using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTicketStatus2
{
    public int StatusId { get; set; }

    public string? StatusName { get; set; }

    public virtual ICollection<WdiMTicket2> WdiMTicket2s { get; set; } = new List<WdiMTicket2>();
}
