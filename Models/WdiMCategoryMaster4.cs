using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMCategoryMaster4
{
    public long CategoryId { get; set; }

    public long PartnerId { get; set; }

    public string? CategoryName { get; set; }

    public string CategoryCode { get; set; } = null!;

    public string CategoryType { get; set; } = null!;

    public bool Active { get; set; }
}
