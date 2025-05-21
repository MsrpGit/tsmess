using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMRoomMaster
{
    public long RoomId { get; set; }

    public long RoomNumber { get; set; }

    public string RoomName { get; set; } = null!;

    public long NoOfBeds { get; set; }

    /// <summary>
    /// Block Id load from Block Table
    /// </summary>
    public long BlockId { get; set; }

    /// <summary>
    /// Room Type is either normal, delux, AC
    /// </summary>
    public string RoomType { get; set; } = null!;

    /// <summary>
    /// Facilities are like wifi,TV,Heat Water... etc
    /// </summary>
    public string Facilities { get; set; } = null!;

    public string Assets { get; set; } = null!;

    public decimal RentAmount { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public long? HostelId { get; set; }

    public long? BuildingId { get; set; }
}
