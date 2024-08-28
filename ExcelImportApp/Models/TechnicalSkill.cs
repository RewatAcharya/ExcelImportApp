using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class TechnicalSkill
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<EconomicDetailTechnicalSkillGroup> EconomicDetailTechnicalSkillGroups { get; set; } = new List<EconomicDetailTechnicalSkillGroup>();
}
