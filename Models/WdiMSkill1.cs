using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSkill1
{
    public int SkillId { get; set; }

    public string? SkillName { get; set; }

    public long? PartnerId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }
}
