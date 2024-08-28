using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class WhereAreTheyNowDetail
{
    public int Id { get; set; }

    public int HouseOwnerDetailsId { get; set; }

    public int WhereAreTheyNowId { get; set; }

    public int? MaleCount { get; set; }

    public int? FemaleCount { get; set; }

    public string Remarks { get; set; }

    public virtual HouseOwnerDetail HouseOwnerDetails { get; set; }

    public virtual WhereAreTheyNow WhereAreTheyNow { get; set; }
}
