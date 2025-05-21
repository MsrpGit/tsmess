using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTSwrstudentDetail
{
    public long Id { get; set; }

    public string? SwruserId { get; set; }

    public string? SocialWelfare { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public DateOnly? Dob { get; set; }

    public string? HallticketNo { get; set; }

    public string? Caste { get; set; }

    public string? CasteCertficateNo { get; set; }

    public string? IncomeCertificateNo { get; set; }

    public string? Orphon { get; set; }

    public string? Pwd { get; set; }

    public string? SainikAdmission { get; set; }

    public string? Preference1 { get; set; }

    public string? Preference2 { get; set; }

    public string? GroupPref1 { get; set; }

    public string? GroupPref2 { get; set; }

    public string? GroupPref3 { get; set; }

    public string? GroupPref4 { get; set; }

    public string? GroupPref5 { get; set; }

    public string? GroupPref6 { get; set; }

    public string? Village { get; set; }

    public string? Mandal { get; set; }

    public string? District { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
