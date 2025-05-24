using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcseclassmappingdetail5
{
    public int MappedClassId { get; set; }

    public int? ClassIds { get; set; }

    public int? ClassCategory { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int PromotedClass { get; set; }
}
