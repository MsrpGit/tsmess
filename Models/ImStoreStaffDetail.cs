using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImStoreStaffDetail
{
    public int Id { get; set; }

    public string AccessId { get; set; } = null!;

    public string StoreId { get; set; } = null!;

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? ContactNo { get; set; }

    public bool Status { get; set; }

    public string? Remarks { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ImStoreDetail Store { get; set; } = null!;
}
