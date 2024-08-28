using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class Tax
{
    public long Id { get; set; }

    public string Name { get; set; }

    public long? LocalLevelId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<TaxDetail> TaxDetails { get; set; } = new List<TaxDetail>();
}
