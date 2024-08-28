using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class Abhadhi
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<HouseOwnerAbdhiGroup> HouseOwnerAbdhiGroups { get; set; } = new List<HouseOwnerAbdhiGroup>();
}
