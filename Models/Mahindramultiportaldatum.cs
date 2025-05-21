using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class Mahindramultiportaldatum
{
    public long Id { get; set; }

    public string? Userid { get; set; }

    public string? Password { get; set; }

    public string? Fname { get; set; }

    public string? Studentmobile { get; set; }

    public string? Studentemailid { get; set; }

    public string? Postcode { get; set; }

    public bool? Gender { get; set; }

    public short? Countryid { get; set; }

    public string? Dob { get; set; }

    public string? Vcode { get; set; }

    public int? Classid { get; set; }

    public string? Section { get; set; }

    public long? Partnerid { get; set; }

    public bool? NewsLetter { get; set; }

    public string? AdmissionNo { get; set; }

    public string? Nationality { get; set; }

    public string? StudentType { get; set; }

    public string? Pwdhsah { get; set; }

    public string? Pwdslat { get; set; }

    public string? StusentAdmissionType { get; set; }

    public string? Fathername { get; set; }

    public string? Fatheremailid { get; set; }

    public string? Fathermobile { get; set; }

    public string? Mothername { get; set; }

    public string? Addess { get; set; }

    public string? TransactionId { get; set; }

    public decimal? TranAmount { get; set; }

    public string? PaymentStatus { get; set; }

    public DateTime? Transactiondate { get; set; }

    public string? PaymentMode { get; set; }

    public string? PlaceOfBirth { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime Createddate { get; set; }
}
