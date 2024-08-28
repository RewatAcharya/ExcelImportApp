using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class HouseDetail
{
    public int Id { get; set; }

    public int? WardNo { get; set; }

    public int HouseFloorId { get; set; }

    public int HouseRoofId { get; set; }

    public int HouseMapId { get; set; }

    public int HouseOwnershipId { get; set; }

    public int HouseOwnerDetailId { get; set; }

    public string AnySuggestions1 { get; set; }

    public virtual HouseFloor HouseFloor { get; set; }

    public virtual HouseMapDetail HouseMap { get; set; }

    public virtual HouseOwnerDetail HouseOwnerDetail { get; set; }

    public virtual HouseOwnership HouseOwnership { get; set; }

    public virtual HouseRoof HouseRoof { get; set; }
}
