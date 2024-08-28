using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class NagarikWadaPatraDoc
{
    public long Id { get; set; }

    public string Name { get; set; }

    public long NagarikWadaPatraId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual NagarikWadaPatra NagarikWadaPatra { get; set; }
}
