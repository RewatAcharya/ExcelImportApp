using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class SleepMotherDetail
{
    public int Id { get; set; }

    public int GharMuliId { get; set; }

    public string Name { get; set; }

    public string PrasutiAddress { get; set; }

    public string PrasutiJach { get; set; }

    public string ChildWeight { get; set; }

    public string IranChakkiDays { get; set; }

    public bool IsSixMonthCompleted { get; set; }

    public bool IsSixMonthEatMotherMilk { get; set; }

    public bool AfterSixMonth { get; set; }

    public string ThapKhanaKoNam { get; set; }

    public virtual HouseOwnerDetail GharMuli { get; set; }
}
