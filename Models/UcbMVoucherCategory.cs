using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UcbMVoucherCategory
{
    public int VoucherCategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? NumberType { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }
}
