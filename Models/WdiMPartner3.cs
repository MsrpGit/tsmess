using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMPartner3
{
    public long PartnerId { get; set; }

    public string UserId { get; set; } = null!;

    public string? Guid { get; set; }

    public string PartnerName { get; set; } = null!;

    /// <summary>
    /// 1:partner; 2:Expert; 3:School;4:Watch2Learn
    /// </summary>
    public short? PartnerType { get; set; }

    public string? PartnerAdress { get; set; }

    /// <summary>
    /// 2: Reject, 1: Accept, 0: New
    /// </summary>
    public short PartnerState { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactNo { get; set; }

    public string? ContactMobile { get; set; }

    public string? ContacteMailAddress { get; set; }

    public string? Website { get; set; }

    public DateTime? SubscriptionDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool SyncStatus { get; set; }

    public int? MenuOrder { get; set; }

    public decimal AccBalance { get; set; }

    public DateTime LastTransDate { get; set; }

    public int SequenceNumber { get; set; }

    public string SenderId { get; set; } = null!;

    public DateTime LastRenewedDate { get; set; }

    public byte[]? EncryptedEmailId { get; set; }

    public byte[]? EncryptedMobile { get; set; }

    public byte[]? EncryptedContactNumber { get; set; }

    public virtual ICollection<WdiMPeriodMaster3> WdiMPeriodMaster3s { get; set; } = new List<WdiMPeriodMaster3>();

    public virtual ICollection<WdiMTicket3> WdiMTicket3s { get; set; } = new List<WdiMTicket3>();

    public virtual ICollection<WdiTTicketlog3> WdiTTicketlog3s { get; set; } = new List<WdiTTicketlog3>();
}
