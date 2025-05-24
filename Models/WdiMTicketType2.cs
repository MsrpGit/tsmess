using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTicketType2
{
    public int TicketTypeId { get; set; }

    public string? TicketTypeName { get; set; }

    public virtual ICollection<WdiMTicket2> WdiMTicket2s { get; set; } = new List<WdiMTicket2>();
}
