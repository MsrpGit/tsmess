using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSession
{
    public int Id { get; set; }

    public string? SessionId { get; set; }

    public string? SessionName { get; set; }

    public DateOnly? DateofSession { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? Presenter { get; set; }

    public string? SessionPwd { get; set; }

    public string? Status { get; set; }

    public long? PartnerId { get; set; }

    public string? LoginUserType { get; set; }
}
