using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class CmpMPayrequest
{
    /// <summary>
    /// prepay token Id
    /// </summary>
    public long PptokenId { get; set; }

    public string UserId { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public decimal Amount { get; set; }

    public string PartnerTransId { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Guid? MasterToken { get; set; }

    public string? Msisdnnum { get; set; }

    public string? AccountRef { get; set; }

    public bool? IsProcessed { get; set; }
}
