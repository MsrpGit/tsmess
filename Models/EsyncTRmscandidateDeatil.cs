using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmscandidateDeatil
{
    public long Id { get; set; }

    public string RmsuserId { get; set; } = null!;

    public string? Name { get; set; }

    public string? MobileNo { get; set; }

    public DateTime? Dob { get; set; }

    public byte? Gender { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string? MaritalStatus { get; set; }

    public string? SpouceName { get; set; }

    public long? Religion { get; set; }

    public long? Nationality { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public string? IndianCitizen { get; set; }

    public string? DisabilityPerson { get; set; }

    public string? DisabilityCategory { get; set; }

    public string? DisabilityPercentage { get; set; }

    public string? GovPsuworkingStatus { get; set; }

    public string? GovPsuorganisationName { get; set; }

    public string? DefenceForeignHostilities { get; set; }

    public string? DefenceHostilitiesInfo { get; set; }

    public string? ExServiceMan { get; set; }

    public DateTime? ExServiceDoj { get; set; }

    public DateTime? ExServiceDor { get; set; }

    public string? ExServiceTotalYears { get; set; }

    public string? EcoandSscoassignment { get; set; }

    public DateTime? EcoandSscodoj { get; set; }

    public DateTime? EcoandSscodor { get; set; }

    public string? EcoadnSscototalYears { get; set; }

    public string? CentrolGovtCivilPost { get; set; }

    public DateTime? CentrolGovtCivilDoj { get; set; }

    public DateTime? CentrolGovtCivilDor { get; set; }

    public string? CentrolGovtCivilTotalYears { get; set; }

    public string? JandKdomiciled { get; set; }

    public string? GovtServant { get; set; }

    public string? GovtServantOrganisation { get; set; }

    public DateTime? GovtServantDoj { get; set; }

    public DateTime? GovtServantDor { get; set; }

    public string? GovtServantServiceYears { get; set; }

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? AadharNo { get; set; }
}
