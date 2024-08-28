using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class WaterDetail
{
    public int Id { get; set; }

    public int WaterResourceId { get; set; }

    public int CookingFuelId { get; set; }

    public int CookingStoveId { get; set; }

    public int LightSourceId { get; set; }

    public int ToiletId { get; set; }

    public int WasteManagementId { get; set; }

    public int? WardNo { get; set; }

    public int HouseOwnerdetailId { get; set; }
}
