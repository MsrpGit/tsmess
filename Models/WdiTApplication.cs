using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTApplication
{
    public long Id { get; set; }

    public int ApplicationNo { get; set; }

    public DateTime? IssueDate { get; set; }

    public decimal? ApplicationAmount { get; set; }

    public long? EnquiryId { get; set; }

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

    /// <summary>
    /// Received
    /// Rejected
    /// Shortlisted
    /// Confirmed
    /// </summary>
    public string? Status { get; set; }

    public string? AdmissionType { get; set; }

    public int? TotalMarks { get; set; }

    public decimal? Percentage { get; set; }

    public string? Result { get; set; }

    public bool IsActive { get; set; }

    public string? XmlData { get; set; }

    public short? Religion { get; set; }

    public short? Caste { get; set; }

    public string? Address { get; set; }

    public byte[]? EncryptedEmailId { get; set; }

    public byte[]? EncryptedMobile { get; set; }

    public byte[]? EncryptedContactNumber { get; set; }

    public byte[]? EncryptedParentEmailId { get; set; }

    public int? Applicationforyearid { get; set; }

    public int? Applicationconfirmyearid { get; set; }

    public string? CommittedFee { get; set; }

    public long? FollowupCount { get; set; }

    public string? FollowupDetails { get; set; }

    public string? EnquiryIncharge { get; set; }

    public string? ExtraFields { get; set; }

    public string? ScholarShipType { get; set; }

    public string? IdentificationMarks1 { get; set; }

    public string? IdentificationMarks2 { get; set; }

    public string? OtherFields { get; set; }

    public byte AppAmountPaidStatus { get; set; }

    public string? AppAmountPaymentReference { get; set; }

    public DateTime? AppAmountPaidDate { get; set; }

    public decimal RegistrationAmount { get; set; }

    public byte RegAmtPaidStatus { get; set; }

    public string? RegAmountPaymentReference { get; set; }

    public DateTime? RegAmountPaidDate { get; set; }

    public string? UserIdAllotted { get; set; }

    public string? ApplicationReceiptNo { get; set; }

    public string PaymentMode { get; set; } = null!;

    public long? MigratePartnerId { get; set; }

    public string? ExtraActivities { get; set; }

    public string? Hobbies { get; set; }

    public string? StudentQualification { get; set; }

    public string? MedicalComplications { get; set; }

    public string? HallTicketNumber { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? XeroxCopies { get; set; }
}
