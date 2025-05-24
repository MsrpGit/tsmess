using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTBranchWiseStudentDue1
{
    public long Id { get; set; }

    public DateTime Date { get; set; }

    public string? AdmissionNo { get; set; }

    public string? UserId { get; set; }

    public string? Name { get; set; }

    public string? Class { get; set; }

    public string? Gender { get; set; }

    public string? MobileNo { get; set; }

    public string? FatherName { get; set; }

    public string? FeeHeadName { get; set; }

    public decimal? ActualFee { get; set; }

    public decimal? ConcessionAmount { get; set; }

    public decimal? AfterConcession { get; set; }

    public decimal? PaidAmount { get; set; }

    public decimal? DueAmount { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
