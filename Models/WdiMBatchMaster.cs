using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMBatchMaster
{
    public int Id { get; set; }

    public string BatchName { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public long? SemisterId { get; set; }

    public int? SubjectId { get; set; }

    public int? BatchType { get; set; }

    public int? EventId { get; set; }

    public bool? IsForAlerts { get; set; }

    public bool? IsForAttendance { get; set; }
}
