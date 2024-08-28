using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class MovedFamilyMemberDetail
{
    public int Id { get; set; }

    public int HouseOwnerDetailsId { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public int? TotalMale { get; set; }

    public int? TotalFemale { get; set; }

    public int? Total { get; set; }

    public string Remarks { get; set; }

    public virtual HouseOwnerDetail HouseOwnerDetails { get; set; }
}
