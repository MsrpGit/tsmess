using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTDescriptorIndicator3
{
    public long Id { get; set; }

    public long PartnerDescriptorId { get; set; }

    public long GradeId { get; set; }

    public string? Grade { get; set; }

    public string? Indicator { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }
}
