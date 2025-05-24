using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSubject4
{
    public int SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public string? Type { get; set; }

    public long? PartnerId { get; set; }

    public bool IsLanguage { get; set; }

    public string? OptingSections { get; set; }
}
