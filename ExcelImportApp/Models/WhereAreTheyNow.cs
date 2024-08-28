using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class WhereAreTheyNow
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int OrderByData { get; set; }

    public virtual ICollection<EducationDetail> EducationDetails { get; set; } = new List<EducationDetail>();

    public virtual ICollection<WhereAreTheyNowDetail> WhereAreTheyNowDetails { get; set; } = new List<WhereAreTheyNowDetail>();
}
