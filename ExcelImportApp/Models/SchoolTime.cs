using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class SchoolTime
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<EducationDetailSchoolGroup> EducationDetailSchoolGroups { get; set; } = new List<EducationDetailSchoolGroup>();
}
