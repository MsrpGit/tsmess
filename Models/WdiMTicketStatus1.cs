using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTicketStatus1
{
    public int StatusId { get; set; }

    public string? StatusName { get; set; }

    public virtual ICollection<WdiMTicket1> WdiMTicket1s { get; set; } = new List<WdiMTicket1>();
}
