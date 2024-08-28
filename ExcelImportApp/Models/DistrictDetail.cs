using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class DistrictDetail
{
    public long Id { get; set; }

    public long DistId { get; set; }

    public string HeadQuater { get; set; }

    public string Pdensity { get; set; }

    public string Population { get; set; }

    public string Area { get; set; }

    public string Website { get; set; }

    public virtual District Dist { get; set; }
}
