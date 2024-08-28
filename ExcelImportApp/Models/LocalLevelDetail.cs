using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class LocalLevelDetail
{
    public long Id { get; set; }

    public long LocalLevelId { get; set; }

    public string Area { get; set; }

    public string Density { get; set; }

    public string Population { get; set; }

    public string Website { get; set; }

    public string Code { get; set; }

    public virtual LocalLevel LocalLevel { get; set; }
}
