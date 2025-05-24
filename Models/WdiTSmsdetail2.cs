using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTSmsdetail2
{
    public int Id { get; set; }

    public DateTime? SmsdateandTime { get; set; }

    public string? UserId { get; set; }

    public int? SmsTypeId { get; set; }

    public short? SmsStatus { get; set; }

    /// <summary>
    /// 0: Low; 1: medium; 2-highest
    /// </summary>
    public short SmsPriority { get; set; }

    public DateTime SmssentDate { get; set; }
}
