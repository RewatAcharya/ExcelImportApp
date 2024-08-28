using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class NagarikWadaPatra
{
    public long Id { get; set; }

    public string Name { get; set; }

    public long LocalLevelId { get; set; }

    public string Charge { get; set; }

    public string TimeRequired { get; set; }

    public string Process { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual LocalLevel LocalLevel { get; set; }

    public virtual ICollection<NagarikWadaPatraDoc> NagarikWadaPatraDocs { get; set; } = new List<NagarikWadaPatraDoc>();
}
