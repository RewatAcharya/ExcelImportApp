using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<HouseOwnerCountryGroup> HouseOwnerCountryGroups { get; set; } = new List<HouseOwnerCountryGroup>();
}
