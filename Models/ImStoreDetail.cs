using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImStoreDetail
{
    public int Id { get; set; }

    public string StoreId { get; set; } = null!;

    public string StoreName { get; set; } = null!;

    public string? ShortCode { get; set; }

    public string? Location { get; set; }

    public string? ContactNo { get; set; }

    public string? AuthorisedPerson { get; set; }

    public string? StoreType { get; set; }

    public bool Status { get; set; }

    public string? Website { get; set; }

    public string? Remarks { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<ImGrnreleasedHistory> ImGrnreleasedHistories { get; set; } = new List<ImGrnreleasedHistory>();

    public virtual ICollection<ImStoreItemStockDetail> ImStoreItemStockDetails { get; set; } = new List<ImStoreItemStockDetail>();

    public virtual ICollection<ImStoreSaleRegister> ImStoreSaleRegisters { get; set; } = new List<ImStoreSaleRegister>();

    public virtual ICollection<ImStoreStaffDetail> ImStoreStaffDetails { get; set; } = new List<ImStoreStaffDetail>();
}
