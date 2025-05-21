using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMFacultyvacancyposition
{
    public long Id { get; set; }

    public long DepartmentId { get; set; }

    public long RoleId { get; set; }

    public int SanctionedPositons { get; set; }

    public int WorkingCount { get; set; }

    public int VacantCount { get; set; }

    public long PartnerId { get; set; }

    public long AcademicyearId { get; set; }
}
