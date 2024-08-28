using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class GharMuliKhanePaniAndAawasDetail
{
    public int Id { get; set; }

    public int GharMuliId { get; set; }

    public bool AnyDisaster { get; set; }

    public string DisasterType { get; set; }

    public bool? FloodDisasterWaterJach { get; set; }

    public string FloodDisasterjachDate { get; set; }

    public bool? IsDrinkingWaterAvilable { get; set; }

    public string DrinkingWaterShrot { get; set; }

    public bool? DrinkingWaterQualityCheck { get; set; }

    public string DrinkingWaterQualityCheckDate { get; set; }

    public string DrinkingWaterQualityCheckTime { get; set; }

    public string ToilatType { get; set; }

    public string ToliteCleaningTime { get; set; }

    public string SabunPaniLeHandWashBani { get; set; }

    public bool? GharayahiKhanePaniRealtedTraning { get; set; }

    public bool? IsHouseRanted { get; set; }

    public string HouseRentType { get; set; }

    public bool? UsedWaterUseForOtherUse { get; set; }

    public string UsedWaterUseForOtherUseType { get; set; }

    public bool? IsKaresabariAvilable { get; set; }

    public string KaresabariArea { get; set; }

    public string HowToAvilableFreshVegitable { get; set; }

    public bool? AreYourFamilyEatProperly { get; set; }

    public string MassuShrot { get; set; }

    public bool? AnyCooperative { get; set; }

    public string CooperativeType { get; set; }

    public bool? AnyRegionalTalim { get; set; }

    public bool? AnyNaturalMedicialKnowlage { get; set; }

    public bool? IsUseNaturalMedicial { get; set; }

    public bool? AnyKnowlageOfOrganicMatter { get; set; }

    public bool? AnyUseOfNaturalSewage { get; set; }

    public bool? AnyUseOfChemicalFertilizer { get; set; }

    public string ChemicalFertilizerName { get; set; }

    public string HowToCookFood { get; set; }

    public bool? IsBuyVegitableInMarket { get; set; }

    public bool? IsBuyFruitsInMarket { get; set; }

    public bool? AnyHouseForAminal { get; set; }

    public string AnimalHouseType { get; set; }

    public bool? ConsumeMilkAndMilkProduct { get; set; }

    public string MilkAndMilkProductMedium { get; set; }

    public string MilkAndMilkProductLiter { get; set; }

    public bool? AnyAnimalForMilkProduce { get; set; }

    public string MilkInLiter { get; set; }

    public string SellMillInLiter { get; set; }

    public string MassuCossumeDays { get; set; }

    public string MassuConsumeInKg { get; set; }

    public bool? IsConssumeEggs { get; set; }

    public string ConssumeEggsTime { get; set; }

    public string ConssumeEggCount { get; set; }

    public bool? AreYouVisitGovermentOffice { get; set; }

    public string FeedBackForEmployee { get; set; }

    public string OfficeService { get; set; }

    public bool? VisitToHealthCare { get; set; }

    public string FeedbackAboutHealthcareEmployee { get; set; }

    public string HealthCareService { get; set; }

    public string AnySuggestions { get; set; }

    public string AnySuggestions1 { get; set; }

    public virtual GharMuliDetail GharMuli { get; set; }
}
