﻿using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class FoodCondition
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<EconomicDetail> EconomicDetails { get; set; } = new List<EconomicDetail>();
}
