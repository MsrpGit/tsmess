using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMUserssecure1
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string? Sslat { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
