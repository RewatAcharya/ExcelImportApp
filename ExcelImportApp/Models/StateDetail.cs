using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class StateDetail
{
    public long Id { get; set; }

    public long StateId { get; set; }

    public string Capital { get; set; }

    public string ChiefMinister { get; set; }

    public string Pdensity { get; set; }

    public string Governer { get; set; }

    public string Population { get; set; }

    public string Area { get; set; }

    public string Website { get; set; }

    public int? TotalDist { get; set; }

    public virtual State State { get; set; }
}
