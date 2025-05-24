using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTicketlog3
{
    public int LogIdPk { get; set; }

    public long PartnerIdFk { get; set; }

    public int IdFk { get; set; }

    public DateOnly? LogDate { get; set; }

    public string? Description { get; set; }

    public string? ActionType { get; set; }

    public string? ActionBy { get; set; }

    public string? ActionComments { get; set; }

    public virtual WdiMTicket3 IdFkNavigation { get; set; } = null!;

    public virtual WdiMPartner3 PartnerIdFkNavigation { get; set; } = null!;
}
