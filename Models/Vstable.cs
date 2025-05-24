using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class Vstable
{
    public string Mobile { get; set; } = null!;

    public string Admissionno { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Class { get; set; }

    public string? Section { get; set; }

    public string? FatherName { get; set; }

    public string? UniCampusAdmissionno { get; set; }
}
