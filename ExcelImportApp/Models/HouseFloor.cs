using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class HouseFloor
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<HouseDetail> HouseDetails { get; set; } = new List<HouseDetail>();
}
