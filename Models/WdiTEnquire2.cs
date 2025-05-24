using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEnquire2
{
    public long Id { get; set; }

    public long EnquiryId { get; set; }

    public DateOnly? EnquiryDate { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public string Fname { get; set; } = null!;

    public string? Lname { get; set; }

    public DateTime Dob { get; set; }

    public bool Gender { get; set; }

    public string? Nationality { get; set; }

    public string? Medium { get; set; }

    public int? FirstLang { get; set; }

    public int? SecondLang { get; set; }

    public string? ContactNumber { get; set; }

    public string? Mobile { get; set; }

    public string? EmailId { get; set; }

    public string? AdmissionYear { get; set; }

    public int? AdmissionClass { get; set; }

    public string? PreviousSchoolName { get; set; }

    public string? PreviousClass { get; set; }

    public string? PreviousSchoolBoard { get; set; }

    public decimal PreviousClassTotalMarks { get; set; }

    public decimal PreviousClassPercentage { get; set; }

    public string? PreviousGrade { get; set; }

    public string? ReasonForLeave { get; set; }

    public string? SourceOfEnquiry { get; set; }

    public string? ParentName { get; set; }

    public string? ParentRelation { get; set; }

    public bool? ParentSex { get; set; }

    public string? ParentQualification { get; set; }

    public string? ParentOccupation { get; set; }

    public string? ParentEmailId { get; set; }

    public string? ParentIncomeRange { get; set; }

    public string? Status { get; set; }

    public string? EnquiryMode { get; set; }

    public string? AdmissionType { get; set; }

    public bool IsActive { get; set; }

    public string? Address { get; set; }

    public byte[]? EncryptedEmailId { get; set; }

    public byte[]? EncryptedMobile { get; set; }

    public byte[]? EncryptedContactNumber { get; set; }

    public byte[]? EncryptedParentEmailId { get; set; }

    public long? FollowupCount { get; set; }

    public string? FollowupDetails { get; set; }

    public string? EnquiryIncharge { get; set; }

    public string? ExtraFields { get; set; }

    public string? ScholarShipType { get; set; }

    public string? IdentificationMarks1 { get; set; }

    public string? IdentificationMarks2 { get; set; }

    public string? Modeofenq { get; set; }

    public string? Counseledby { get; set; }

    public string? Enqremarks { get; set; }

    public DateOnly? Enqreturndate { get; set; }

    public string? Eamcetrank { get; set; }

    public string? Isdefence { get; set; }

    public int MailStatus { get; set; }

    public string? BusFacility { get; set; }

    public int? Age { get; set; }
}
