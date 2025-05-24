using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTaskSmsemailstatus3
{
    public long TaskStatusId { get; set; }

    public long HomeworkTaskId { get; set; }

    public string UserId { get; set; } = null!;

    public byte Smsstatus { get; set; }

    public byte EmailStatus { get; set; }

    public DateTime SendDate { get; set; }
}
