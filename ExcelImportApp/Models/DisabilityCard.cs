﻿using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class DisabilityCard
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<HealthDetailDisabilityCardGroup> HealthDetailDisabilityCardGroups { get; set; } = new List<HealthDetailDisabilityCardGroup>();
}
