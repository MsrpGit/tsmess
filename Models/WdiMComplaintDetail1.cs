using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMComplaintDetail1
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public long? AcademicYearId { get; set; }

    public string? ContactNo { get; set; }

    public string Subject { get; set; } = null!;

    public string ComplaintDescription { get; set; } = null!;

    /// <summary>
    /// 0 ---- Pending ;   1------- Completed ;  2 ---- Rejected  ;   3 --- Progress ; -1 -----In-Active the Message
    /// </summary>
    public int Status { get; set; }

    public string? Remarks { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? EmailId { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? ParentComplaint { get; set; }
}
