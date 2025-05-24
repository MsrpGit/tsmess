using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTMealMenuConsumedDetail1
{
    public int Id { get; set; }

    public long MealiteamId { get; set; }

    public decimal? ConsumedMealQty { get; set; }

    public DateTime? Consumeddate { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
