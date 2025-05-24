using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTM2mStudentExitDetail2
{
    public int Id { get; set; }

    public string? ExitreferenceNo { get; set; }

    public string? StudentUserId { get; set; }

    public DateTime? Date { get; set; }

    public decimal? PaidAmount { get; set; }

    public decimal? ForfeitedAmount { get; set; }

    public decimal? RefundedAmount { get; set; }

    public string? Requeststatus { get; set; }

    public DateTime? ParentRequestedDate { get; set; }

    public DateTime? RequestApprovaldate { get; set; }

    public string? VerifiedBy { get; set; }

    public string? ApprovedBy { get; set; }

    public string? Remarks { get; set; }

    public int? PartnerId { get; set; }

    public int? AcademicYearId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public decimal? ProposedForfeitedAmt { get; set; }

    public decimal? ProposedRefundAmt { get; set; }

    public string? AppliedBy { get; set; }

    public DateTime? AppliedDate { get; set; }

    public DateTime? VerifiedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public bool? IsVerified { get; set; }

    public decimal? HstlPaidAmt { get; set; }

    public decimal? HstlProposedForfeitedAmt { get; set; }

    public decimal? HstlProposedRefundAmt { get; set; }

    public decimal? HstlForfeitedAmt { get; set; }

    public decimal? HstlRefundAmt { get; set; }

    public bool? HstlFeeExist { get; set; }
}
