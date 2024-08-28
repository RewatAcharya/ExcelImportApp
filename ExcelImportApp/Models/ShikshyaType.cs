using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class ShikshyaType
{
    public long Id { get; set; }

    public string Name { get; set; }

    public bool? IsDeleted { get; set; }
}
