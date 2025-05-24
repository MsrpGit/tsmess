using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTMessage1
{
    public long MsgId { get; set; }

    public string FromId { get; set; } = null!;

    public string ToId { get; set; } = null!;

    public string? Subject { get; set; }

    public string Body { get; set; } = null!;

    public DateTime MsgDate { get; set; }

    public int MsgType { get; set; }

    /// <summary>
    /// 1 - UN READ, 2 - READ, 3 - TRASH, 4 - MOVE TO PARTICULAR FOLDER, 5 - DELETE(RECORD EXISTS BUT WON&apos;T BE SEEN IN TRASH).
    /// </summary>
    public byte? MsgStat { get; set; }

    public byte? MsgSnt { get; set; }
}
