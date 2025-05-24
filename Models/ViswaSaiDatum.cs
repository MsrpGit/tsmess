using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ViswaSaiDatum
{
    public string Mobile { get; set; } = null!;

    public string Admissionno { get; set; } = null!;

    public string? Name { get; set; }

    public string? FatherName { get; set; }
}
