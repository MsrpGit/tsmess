using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class CsaMMcadmission
{
    public long Id { get; set; }

    public int Totalallindiaseats { get; set; }

    public int Totalallindiaseatsfilled { get; set; }

    public int Totalallindiavacantseats { get; set; }

    public int Totalstateseats { get; set; }

    public int Totalstateseatsfilled { get; set; }

    public int Totalstatevacantseats { get; set; }

    public int Totalseatssanctioned { get; set; }

    public int Totalvacantseats { get; set; }

    public string Classname { get; set; } = null!;

    public string PartnerName { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public DateTime ProcessedDate { get; set; }
}
