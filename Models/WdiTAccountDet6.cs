using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTAccountDet6
{
    public string UserId { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public string? Lname { get; set; }

    public string? Mobile { get; set; }

    public string? EmailId { get; set; }

    public string? PostalCode { get; set; }

    public bool Gender { get; set; }

    public short CountryId { get; set; }

    public DateTime Dob { get; set; }

    public string? VerificationCode { get; set; }

    public DateTime? RegisteredDate { get; set; }

    public string? State { get; set; }

    public bool? Mail { get; set; }

    public string? Img { get; set; }

    public string? AboutMe { get; set; }

    public string? Website { get; set; }

    public bool? SyncStatus { get; set; }

    public string? Medium { get; set; }

    public long? SchoolId { get; set; }

    public string? AdmissionNo { get; set; }

    public DateTime? AdmissionDate { get; set; }

    public string? MiddleName { get; set; }

    public short? Religion { get; set; }

    public short? Caste { get; set; }

    public string? BloodGroup { get; set; }

    public string? PresentAddress { get; set; }

    public string? PresentCity { get; set; }

    public string? PermanentAddress { get; set; }

    public string? PermanentCity { get; set; }

    public string? PermanentState { get; set; }

    public short? PermanentCountryId { get; set; }

    public string? PermanentPostalCode { get; set; }

    public string? ContactNumber { get; set; }

    public string? IdentificationMarks1 { get; set; }

    public string? IdentificationMarks2 { get; set; }

    public string? PreviousSchoolName { get; set; }

    public string? PreviousClass { get; set; }

    public string? ProfileImagePath { get; set; }

    public string? Nationality { get; set; }

    public long? RouteNo { get; set; }

    public int? ClassAdmitted { get; set; }

    public int? SectionAdmitted { get; set; }

    public int? FirstLang { get; set; }

    public int? SecondLang { get; set; }

    public long? LocationId { get; set; }

    public string? RouteType { get; set; }

    public long AcademicYearId { get; set; }

    /// <summary>
    /// &apos;DAY SCHOLAR&apos; OR &apos;RESIDENTIAL&apos;
    /// </summary>
    public string StudentType { get; set; } = null!;

    public decimal PreviousClassTotalMarks { get; set; }

    public decimal PreviousClassPercentage { get; set; }

    public string? PreviousSchoolBoard { get; set; }

    public string? Empid { get; set; }

    public string? ExtraFields { get; set; }

    public byte[]? EncryptedEmailId { get; set; }

    public byte[]? EncryptedMobileNo { get; set; }

    /// <summary>
    ///  0 --- No Need App Notifications  ;   1 --- Need App Notifications..
    /// </summary>
    public byte AppNotificationOnly { get; set; }

    public string? GoogleAppUserRegId { get; set; }

    public string? MotherTongue { get; set; }

    public string? EnquiryIncharge { get; set; }

    public string? AdmissionReference { get; set; }

    public string? ScholarShipApplied { get; set; }

    public string? SubCaste { get; set; }

    public long EnrollNo { get; set; }

    public string? SourceOfEnquiry { get; set; }

    public byte? IsEnrolledInApp { get; set; }

    public string? PreviousInstituteDetails { get; set; }

    public string? StudentAdmissionType { get; set; }

    public string? Placeofbirth { get; set; }

    public string? ChildInfoId { get; set; }

    public string? BoardAdmNo { get; set; }
}
