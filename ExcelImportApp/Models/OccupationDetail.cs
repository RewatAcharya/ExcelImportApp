using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class OccupationDetail
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<PopulationDetailOccupationGroup> PopulationDetailOccupationGroups { get; set; } = new List<PopulationDetailOccupationGroup>();
}
