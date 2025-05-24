using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTQuickConnectSm5
{
    public int QuickConnectSmsid { get; set; }

    public int ContactId { get; set; }

    /// <summary>
    /// 0 - SMS Send Failed , 1 - SMS Send Successfull.
    /// </summary>
    public byte Smsstatus { get; set; }

    public DateTime SendOn { get; set; }
}
