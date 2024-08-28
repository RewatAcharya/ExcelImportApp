using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class EducationalLevel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<EducationEducationalLevelGroup> EducationEducationalLevelGroups { get; set; } = new List<EducationEducationalLevelGroup>();

    public virtual ICollection<GharMuliFamilyDetail> GharMuliFamilyDetails { get; set; } = new List<GharMuliFamilyDetail>();
}
