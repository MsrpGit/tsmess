using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UcNewOnboardingRequest
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string About { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string LocalAddress { get; set; } = null!;

    public string ContactMobile { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string ContacteMail { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string ContactPerson { get; set; } = null!;

    public short ApprovalStatus { get; set; }

    public string ApprovedBy { get; set; } = null!;

    public string ActualStatus { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
