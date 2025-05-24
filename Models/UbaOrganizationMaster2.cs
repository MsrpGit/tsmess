using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UbaOrganizationMaster2
{
    public long OrganizationId { get; set; }

    public string OrgName { get; set; } = null!;

    public string OrgTitle { get; set; } = null!;

    public string OrgBrand { get; set; } = null!;

    public string OrgShortCode { get; set; } = null!;

    public string? OrgCode { get; set; }

    public string? OrgCategoryOfService { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactPhoneNo { get; set; }

    public string? MobileNo { get; set; }

    public string? FaxNo { get; set; }

    public string? Currency { get; set; }

    public string? CurrencyDecimalNotation { get; set; }

    public string? OrgLogo { get; set; }

    public string? OrgHeaderLogo { get; set; }

    public string? OrgAddress { get; set; }

    public byte OrgStatus { get; set; }

    public string? OrgGstin { get; set; }

    public string? OrgServiceTaxNo { get; set; }

    public string? OrgVatNo { get; set; }

    public string? OrgPanno { get; set; }

    public string? OrgTinno { get; set; }

    public string? OrgCinno { get; set; }

    public string? OrgCstno { get; set; }

    public string? OrgExciseNo { get; set; }

    public string? OrgExciseRange { get; set; }

    public string? OrgExciseDivision { get; set; }

    public string? OrgCommissionerate { get; set; }

    public string? OrgRemarks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
