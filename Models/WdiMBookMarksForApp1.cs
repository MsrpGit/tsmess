using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMBookMarksForApp1
{
    public int Id { get; set; }

    public long ClassId { get; set; }

    public long SectionId { get; set; }

    public string UserId { get; set; } = null!;

    public long? PartnerId { get; set; }

    public string? Type { get; set; }

    public DateTime CreatedDate { get; set; }
}
