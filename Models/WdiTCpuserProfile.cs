using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTCpuserProfile
{
    public string UserId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Mobile { get; set; }

    public string? EmailId { get; set; }

    public string? PostalCode { get; set; }

    public bool Gender { get; set; }

    public string? VerificationCode { get; set; }

    public DateTime? RegisteredDate { get; set; }

    public string? AboutMe { get; set; }

    public string? PresentAddress { get; set; }

    public string? PresentCity { get; set; }

    public string? PresentState { get; set; }

    public short? PresentCountryId { get; set; }

    public string? PermanentAddress { get; set; }

    public string? PermanentCity { get; set; }

    public string? PermanentState { get; set; }

    public short? PermanentCountryId { get; set; }

    public string? PermanentPostalCode { get; set; }

    public string? ProfileImagePath { get; set; }
}
