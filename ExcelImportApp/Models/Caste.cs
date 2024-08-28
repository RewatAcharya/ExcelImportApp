using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class Caste
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<GharMuliDetail> GharMuliDetails { get; set; } = new List<GharMuliDetail>();

    public virtual ICollection<PopulationDetailCasteGroup> PopulationDetailCasteGroups { get; set; } = new List<PopulationDetailCasteGroup>();
}
