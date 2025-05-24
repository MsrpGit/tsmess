using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMFeeHeadsMappingMaster3
{
    public int Id { get; set; }

    public long SectionId { get; set; }

    public long FeeHeadId { get; set; }

    public long ClassId { get; set; }

    public long AcademicyearId { get; set; }
}
