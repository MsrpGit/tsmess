using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMCountry4
{
    public int CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public string? CountryCode { get; set; }

    public string? TimeZone { get; set; }
}
