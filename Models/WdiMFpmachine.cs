using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMFpmachine
{
    public long Id { get; set; }

    public long PartnerId { get; set; }

    public string MachineNo { get; set; } = null!;

    public string MachineDetails { get; set; } = null!;

    public DateTime Installdate { get; set; }

    public bool Status { get; set; }

    /// <summary>
    /// FP: finger print ; GP : GPS related Device; one partner can have multiple number of devices
    /// </summary>
    public string MachineType { get; set; } = null!;
}
