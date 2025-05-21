using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncTRmscandidateContactDetail
{
    public long Id { get; set; }

    public string? RmsuserId { get; set; }

    public string? MobileNo { get; set; }

    public string? AlternativeMobileNo { get; set; }

    public string? LandlineNo { get; set; }

    public string? EmailId { get; set; }

    public string? AlternativeEmailId { get; set; }

    public string? PresentHouseNo { get; set; }

    public string? PresentStreetNo { get; set; }

    public string? PresentPo { get; set; }

    public string? PresentVia { get; set; }

    public string? PresentCity { get; set; }

    public string? PresentState { get; set; }

    public string? PresentPinCode { get; set; }

    public string? PermanentHouseNo { get; set; }

    public string? PermanentStreetNo { get; set; }

    public string? PermanentPo { get; set; }

    public string? PermanentVia { get; set; }

    public string? PermanentCity { get; set; }

    public string? PermanentPinCode { get; set; }

    public string? Remarks { get; set; }

    public string? CommunicationRequiredFor { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? PermanentState { get; set; }
}
