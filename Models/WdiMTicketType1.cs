using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTicketType1
{
    public int TicketTypeId { get; set; }

    public string? TicketTypeName { get; set; }

    public virtual ICollection<WdiMTicket1> WdiMTicket1s { get; set; } = new List<WdiMTicket1>();
}
