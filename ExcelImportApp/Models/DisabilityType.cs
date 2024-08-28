using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class DisabilityType
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<HealthDetailDisabilityTypeGroup> HealthDetailDisabilityTypeGroups { get; set; } = new List<HealthDetailDisabilityTypeGroup>();
}
