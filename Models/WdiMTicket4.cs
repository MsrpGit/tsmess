using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTicket4
{
    public int IdPk { get; set; }

    public string? TicketId { get; set; }

    public long PartnerIdFk { get; set; }

    public int ModuleIdFk { get; set; }

    public int StatusIdFk { get; set; }

    public int TicketTypeIdFk { get; set; }

    public DateOnly? DateOfIssue { get; set; }

    public string? PostedBy { get; set; }

    public string? TicketDescription { get; set; }

    public string? UpdatedBy { get; set; }

    public DateOnly? ModifiedDate { get; set; }

    public string? TicketServerityLevel { get; set; }

    public string? AssignedTo { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual WdiMTenantModule5 ModuleIdFkNavigation { get; set; } = null!;

    public virtual WdiMPartner5 PartnerIdFkNavigation { get; set; } = null!;

    public virtual WdiMTicketStatus4 StatusIdFkNavigation { get; set; } = null!;

    public virtual WdiMTicketType4 TicketTypeIdFkNavigation { get; set; } = null!;

    public virtual ICollection<WdiTTicketlog4> WdiTTicketlog4s { get; set; } = new List<WdiTTicketlog4>();
}
