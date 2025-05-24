using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UsMMobileConfig
{
    public int Id { get; set; }

    public long PartnerId { get; set; }

    public string? PartnerName { get; set; }

    public string? LoginLogoUrl { get; set; }

    public string? LoginBackgroundColor { get; set; }

    public string? LoginBackgroundImage { get; set; }

    public string? DashboardBackgroundColor { get; set; }

    public string? DashboardBackgroundImage { get; set; }

    public string? AllScreensHeaderColor { get; set; }

    public string? AllScreensHeaderImage { get; set; }

    public string? AllPrimaryButtonsColorCode { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
