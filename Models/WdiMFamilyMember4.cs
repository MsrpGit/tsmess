using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMFamilyMember4
{
    public long FamilyMemberId { get; set; }

    public string? UserId { get; set; }

    public string Relation { get; set; } = null!;

    public string? Qualification { get; set; }

    public string? Occupation { get; set; }

    public string? EmailId { get; set; }

    public string? PhoneNo { get; set; }

    public string? Mobile { get; set; }

    public string? Sex { get; set; }

    public byte[]? EncryptedMobileNo { get; set; }

    public byte[]? EncryptedPhoneNo { get; set; }

    public byte[]? EncryptedMemberName { get; set; }

    public byte[]? EncryptedEmailId { get; set; }
}
