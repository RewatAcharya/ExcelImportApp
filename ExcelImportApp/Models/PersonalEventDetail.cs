using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class PersonalEventDetail
{
    public int Id { get; set; }

    public int WadaNo { get; set; }

    public int Birth { get; set; }

    public int Death { get; set; }

    public int Married { get; set; }

    public int Couples { get; set; }
}
