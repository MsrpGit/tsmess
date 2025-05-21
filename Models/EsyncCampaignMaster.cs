using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncCampaignMaster
{
    public long CampaignId { get; set; }

    public string CampaignName { get; set; } = null!;

    public string? Description { get; set; }

    public string Type { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public long? AcademicyearId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string Status { get; set; } = null!;
}
