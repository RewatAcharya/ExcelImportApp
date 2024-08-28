using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class WardDetail
{
    public long Id { get; set; }

    public long? WardId { get; set; }

    public string Area { get; set; }

    public string Density { get; set; }

    public string Popullation { get; set; }

    public virtual Ward Ward { get; set; }
}
