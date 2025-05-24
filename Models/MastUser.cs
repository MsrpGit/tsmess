using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class MastUser
{
    public int SchemaId { get; set; }

    public string? SchemaName { get; set; }

    public string UserId { get; set; } = null!;

    public string? Mobile { get; set; }

    public string? EmailId { get; set; }

    public long? Partnerid { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }
}
