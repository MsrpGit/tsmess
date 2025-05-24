using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAchievement3
{
    public int AchieveId { get; set; }

    public string? UserId { get; set; }

    public string AchievementDetails { get; set; } = null!;

    public DateTime AchievedDate { get; set; }

    public string Location { get; set; } = null!;

    public string Position { get; set; } = null!;

    public long PartnerId { get; set; }

    public string? EventDate { get; set; }
}
