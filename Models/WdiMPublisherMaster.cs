using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMPublisherMaster
{
    public long PublisherId { get; set; }

    public string PublisherName { get; set; } = null!;

    public string? City { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? State { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Country { get; set; }

    public string? Pin { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public long Partnerid { get; set; }

    public bool Active { get; set; }
}
