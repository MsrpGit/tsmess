using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentExamRemark3
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public long ExamId { get; set; }

    public int RemarkId { get; set; }
}
