using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMClub3
{
    public long ClubId { get; set; }

    public string? ClubName { get; set; }

    public long PartnerId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? RecStatus { get; set; }
}
