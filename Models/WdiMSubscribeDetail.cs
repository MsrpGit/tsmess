using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSubscribeDetail
{
    public long Id { get; set; }

    public long PartnerId { get; set; }

    public int TotalStaff { get; set; }

    public int TotalStudents { get; set; }

    public long TotalUsersSubscribed { get; set; }

    public long NewAdmissions { get; set; }

    public long TotalSmsSubscribed { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
