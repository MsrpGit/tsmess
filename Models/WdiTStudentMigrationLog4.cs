using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentMigrationLog4
{
    public int Id { get; set; }

    public string? TransferrefNo { get; set; }

    public string? StudentUserId { get; set; }

    public DateTime? Date { get; set; }

    public int? PresentClassId { get; set; }

    public int? PresentSectionId { get; set; }

    public int? TargetClassId { get; set; }

    public int? TargetSectionId { get; set; }

    public string? Requeststatus { get; set; }

    public string? VerifiedBy { get; set; }

    public string? ApprovedBy { get; set; }

    public string? Remarks { get; set; }

    public int? SourcePartnerId { get; set; }

    public int? SourceAcademicYearId { get; set; }

    public int? TargetpartnerId { get; set; }

    public int? TargetAcademicyearId { get; set; }

    public string? TransferdType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
