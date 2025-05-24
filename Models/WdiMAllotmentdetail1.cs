using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAllotmentdetail1
{
    public int AllotmentId { get; set; }

    public long HostelId { get; set; }

    public long BuildingId { get; set; }

    public long BlockId { get; set; }

    public long RoomId { get; set; }

    public long ClassId { get; set; }

    public long SectionId { get; set; }

    public string UserId { get; set; } = null!;

    public int BedNo { get; set; }

    public DateTime AllotedDate { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    /// <summary>
    /// 0 -- Active (Present Alloted Seat)  ; 1 -- Inactive (previous Alloted Seat)  ;   -1 --- Seat Waiting for Conformation. ;   2 --- Vacated User Details.
    /// </summary>
    public int Status { get; set; }

    public DateTime? VacationDate { get; set; }
}
