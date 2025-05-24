using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class SchemasList
{
    public int Id { get; set; }

    public string? TableName { get; set; }

    public string? SchemaName { get; set; }

    public string? ConnString { get; set; }
}
