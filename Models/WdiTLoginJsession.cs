using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTLoginJsession
{
    public long Id { get; set; }

    public long PartnerId { get; set; }

    public string UserId { get; set; } = null!;

    public long AcademicYearId { get; set; }

    public string JsessioId { get; set; } = null!;

    public DateTime Createddate { get; set; }

    public bool Status { get; set; }

    public DateTime? Logoutdate { get; set; }
}
