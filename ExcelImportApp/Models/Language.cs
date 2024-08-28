using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class Language
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<GharMuliDetail> GharMuliDetails { get; set; } = new List<GharMuliDetail>();

    public virtual ICollection<PopulationDetail> PopulationDetails { get; set; } = new List<PopulationDetail>();
}
