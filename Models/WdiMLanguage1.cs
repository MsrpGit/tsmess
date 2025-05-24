using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMLanguage1
{
    public int LanguageId { get; set; }

    public string LanguageName { get; set; } = null!;

    public string Culture { get; set; } = null!;
}
