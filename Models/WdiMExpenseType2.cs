using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMExpenseType2
{
    public int ExpenseTypeId { get; set; }

    public string Expenses { get; set; } = null!;

    public string PartnerId { get; set; } = null!;
}
