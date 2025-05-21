using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTaskSmsemailstatus
{
    public long TaskStatusId { get; set; }

    public long HomeworkTaskId { get; set; }

    public string UserId { get; set; } = null!;

    public byte Smsstatus { get; set; }

    public byte EmailStatus { get; set; }

    public DateTime? SendDate { get; set; }

    public string TaskStatus { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime SubmissionDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
