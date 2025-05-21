using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class VwStaffDetail
{
    public string? EmpId { get; set; }

    public string UserName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string Mobile { get; set; } = null!;

    public string EMailId { get; set; } = null!;

    public long? FingerPrintId { get; set; }

    public string? PresentAddress { get; set; }

    public string? PresentCity { get; set; }

    public string? PostalCode { get; set; }

    public string? PermanentAddress { get; set; }

    public string? PermanentCity { get; set; }

    public string? PermanentPostalCode { get; set; }

    public string? Qualification { get; set; }

    public string? Classes { get; set; }

    public string? Subjects { get; set; }

    public string? Experience { get; set; }

    public string? Achievements { get; set; }

    public string? StaffBlock { get; set; }

    public string? BloodGroup { get; set; }

    public string? HeightInFeet { get; set; }

    public string? WeightInKg { get; set; }

    public string? VisionRight { get; set; }

    public string? VisionLeft { get; set; }

    public string? Dental { get; set; }

    public string? Oral { get; set; }

    public string? SpecificAliments { get; set; }

    public string? Medication { get; set; }

    public string? PanNo { get; set; }

    public string? VoterId { get; set; }

    public string? AdharNo { get; set; }

    public string? BankName { get; set; }

    public string? MaritalStatus { get; set; }

    public string? PreviosWorkPlace { get; set; }

    public string? PreviousCompanyAddress { get; set; }

    public string? ReasonForLeave { get; set; }

    public string? SpouseName { get; set; }

    public string? AnniversaryDate { get; set; }

    public string? Role { get; set; }

    public long AcademicYearId { get; set; }

    public long? PartnerId { get; set; }
}
