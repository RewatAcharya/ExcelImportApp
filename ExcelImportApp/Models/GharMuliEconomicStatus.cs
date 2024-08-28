using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class GharMuliEconomicStatus
{
    public int Id { get; set; }

    public int GharMuliId { get; set; }

    public string IncomeShrotAgriculture { get; set; }

    public decimal? IncomeYearly { get; set; }

    public bool? AnyOtherIncomeSource { get; set; }

    public string OtherIncomeSourceName { get; set; }

    public decimal? OtherIncomeYearly { get; set; }

    public bool? FamilyBusiness { get; set; }

    public int? FamilyBusinessNo { get; set; }

    public bool? FamilyEmployment { get; set; }

    public string FamilyEmploymentName { get; set; }

    public string FamilyEmploymentDuration { get; set; }

    public bool? FamilyProductQuality { get; set; }

    public bool? FamilyProductEnough { get; set; }

    public virtual GharMuliDetail GharMuli { get; set; }
}
