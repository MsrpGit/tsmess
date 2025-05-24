using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMLibraryeligibility3
{
    public long EligibilityId { get; set; }

    public long? CategoryId { get; set; }

    public long? ItemId { get; set; }

    public int? MaxDays { get; set; }

    public decimal? Fine { get; set; }

    public int? MaxItems { get; set; }

    public int RoleId { get; set; }

    public long PartnerId { get; set; }

    public bool Active { get; set; }

    public long AcademicYearId { get; set; }

    public int? ClassId { get; set; }

    public int? BookBankMaxDays { get; set; }

    public int? BookBankMaxItems { get; set; }

    public decimal? BookBankFine { get; set; }
}
