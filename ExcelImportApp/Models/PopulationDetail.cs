using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class PopulationDetail
{
    public int Id { get; set; }

    public int? WardNo { get; set; }

    public int ReligionId { get; set; }

    public bool IsMarried { get; set; }

    public bool IsBusinessSkill { get; set; }

    public int LanguageId { get; set; }

    public int HouseOwnerDetailId { get; set; }

    public virtual Language Language { get; set; }

    public virtual ICollection<PopulationDetailAgeGroup> PopulationDetailAgeGroups { get; set; } = new List<PopulationDetailAgeGroup>();

    public virtual ICollection<PopulationDetailCasteGroup> PopulationDetailCasteGroups { get; set; } = new List<PopulationDetailCasteGroup>();

    public virtual ICollection<PopulationDetailOccupationGroup> PopulationDetailOccupationGroups { get; set; } = new List<PopulationDetailOccupationGroup>();

    public virtual Religion Religion { get; set; }
}
