using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UbaSsconsessionTransaction
{
    public long SstransId { get; set; }

    public string UserId { get; set; } = null!;

    public int SsconcessionId { get; set; }

    public decimal TotalConcession { get; set; }

    public DateTime ConcessionDate { get; set; }

    public string ConcessionBy { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? OrderofScholorship { get; set; }

    public string? ScholorshipGroup { get; set; }

    public string? ApprovedBy { get; set; }

    public string? VerifiedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? Status { get; set; }

    public string? EmployeeId { get; set; }

    public string? DocRefNo { get; set; }
}
