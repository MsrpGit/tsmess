using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPartnerProfile
{
    public long PartnerId { get; set; }

    public string PartnerTitle { get; set; } = null!;

    public string PartnerDesc { get; set; } = null!;

    public string? PartnerImage { get; set; }

    public string? BackgroundImage { get; set; }

    public string? FontType { get; set; }

    public string? FontColor { get; set; }

    public string? BackgroundColor { get; set; }

    public bool IsExpert { get; set; }

    public string? Subjects { get; set; }

    public string? TotalExperience { get; set; }

    public string? ExperienceDetails { get; set; }

    public string? Qualification { get; set; }

    public string Designation { get; set; } = null!;

    public string? SchoolCategories { get; set; }

    public DateTime? FormationDate { get; set; }

    public string? BankDetails { get; set; }

    public string? MembersofHonor { get; set; }

    public string Affiliationno { get; set; } = null!;

    public string Schoolcode { get; set; } = null!;

    public string Schooludisecode { get; set; } = null!;
}
