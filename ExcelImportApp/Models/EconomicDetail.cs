using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class EconomicDetail
{
    public int Id { get; set; }

    public bool IsHouseRanted { get; set; }

    public bool IsAnyDebt { get; set; }

    public int AverageMonthlyIncomeId { get; set; }

    public int FoodConditionId { get; set; }

    public int TechnicalSkillId { get; set; }

    public int? WardNo { get; set; }

    public int HouseOwnerDetailId { get; set; }

    public string MukhyaPeshaKho { get; set; }

    public int? KatiJanaSanglagna { get; set; }

    public int? Male { get; set; }

    public int? Female { get; set; }

    public int? Other { get; set; }

    public virtual AverageMonthlyIncome AverageMonthlyIncome { get; set; }

    public virtual ICollection<EconomicDetailTechnicalSkillGroup> EconomicDetailTechnicalSkillGroups { get; set; } = new List<EconomicDetailTechnicalSkillGroup>();

    public virtual FoodCondition FoodCondition { get; set; }

    public virtual HouseOwnerDetail HouseOwnerDetail { get; set; }
}
