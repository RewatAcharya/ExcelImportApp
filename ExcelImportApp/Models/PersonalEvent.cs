using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class PersonalEvent
{
    public int Id { get; set; }

    public int? Birth { get; set; }

    public int? Death { get; set; }
}
