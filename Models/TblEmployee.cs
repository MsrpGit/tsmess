using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class TblEmployee
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public string? Salary { get; set; }
}
