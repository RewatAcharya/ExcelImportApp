using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class GharMuliDetail
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string ContactNo { get; set; }

    public int? GenderId { get; set; }

    public int? CasteId { get; set; }

    public int? ReligionId { get; set; }

    public int? LanguageId { get; set; }

    public string Village { get; set; }

    public string GharNo { get; set; }

    public string OldWardNo { get; set; }

    public long? WardId { get; set; }

    public string Photo { get; set; }

    public string GharKoPhoto { get; set; }

    public virtual Caste Caste { get; set; }

    public virtual Gender Gender { get; set; }

    public virtual ICollection<GharMuliEconomicStatus> GharMuliEconomicStatuses { get; set; } = new List<GharMuliEconomicStatus>();

    public virtual ICollection<GharMuliFamilyDetail> GharMuliFamilyDetails { get; set; } = new List<GharMuliFamilyDetail>();

    public virtual ICollection<GharMuliHealthDetail> GharMuliHealthDetails { get; set; } = new List<GharMuliHealthDetail>();

    public virtual ICollection<GharMuliKhanePaniAndAawasDetail> GharMuliKhanePaniAndAawasDetails { get; set; } = new List<GharMuliKhanePaniAndAawasDetail>();

    public virtual Language Language { get; set; }

    public virtual Religion Religion { get; set; }

    public virtual Ward Ward { get; set; }
}
