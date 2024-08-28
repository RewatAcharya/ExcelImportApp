using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class GharMuliChildDetail
{
    public int Id { get; set; }

    public int GharMuliId { get; set; }

    public string Name { get; set; }

    public int? BoysCount { get; set; }

    public int? GirlsCount { get; set; }

    public string Remarks { get; set; }

    public bool? IranChakkiEat { get; set; }

    public bool? SexEducationKnown { get; set; }

    public virtual HouseOwnerDetail GharMuli { get; set; }
}
