using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentAcademicProfile5
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public long AcademicyearId { get; set; }

    public long ElectiveCode { get; set; }

    public long SubjectId { get; set; }

    public long FirstLanguage { get; set; }

    public long SecondLanguage { get; set; }

    public long ThirdLanguage { get; set; }
}
