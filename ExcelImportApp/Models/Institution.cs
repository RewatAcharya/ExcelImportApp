using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class Institution
{
    public int Id { get; set; }

    public int? School { get; set; }

    public int? GovernmentOffice { get; set; }

    public int? Bank { get; set; }

    public int? HealthPost { get; set; }

    public int? Industry { get; set; }

    public int? CulturalHeritage { get; set; }

    public int? NaturalResource { get; set; }

    public int? TownWardOffice { get; set; }

    public long WardNo { get; set; }

    public int? SecurityAgencies { get; set; }

    public virtual Ward WardNoNavigation { get; set; }
}
