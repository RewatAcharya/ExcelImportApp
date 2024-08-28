using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class TaxDetail
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Amount { get; set; }

    public long? TaxId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Tax Tax { get; set; }
}
