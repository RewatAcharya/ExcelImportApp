using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class MultisectoralNutritionAndExtension
{
    public int Id { get; set; }

    public int HouseOwnerDetailId { get; set; }

    public bool? AnyPregnancy { get; set; }

    public bool? AnySleepMotherInYourHouse { get; set; }

    public bool? AnyHivcase { get; set; }

    public string ThapKhanaKhuwaunu { get; set; }

    public bool? IsBornChildHivinfected { get; set; }

    public bool? Arvprophylaxis { get; set; }

    public bool? Is12YearChild { get; set; }

    public string ChildKhopDetails { get; set; }

    public bool? Is16YearChild { get; set; }

    public bool? IsKhopCard { get; set; }

    public string SixMto5YbitminAkhopPatak { get; set; }

    public string OneTo5YjukaKhopPatak { get; set; }

    public bool? Is24Mchaild { get; set; }

    public bool? IsWeighted { get; set; }

    public string HowManyTimes { get; set; }

    public string WeightThau { get; set; }

    public bool? AnyChildHealthIssue { get; set; }

    public string HealthIssuColorType { get; set; }

    public string EatNunType { get; set; }

    public bool? AnyDiarrheaIssue { get; set; }

    public bool? DiarrheaTimeEatJinkChaki { get; set; }

    public int? DiarrheaTimeEatDays { get; set; }

    public bool? DiarrheaTimeEatPunJaliyaJhol { get; set; }

    public bool? IsNotGoToSchool5To14Child { get; set; }

    public string CurrentAddeess { get; set; }

    public bool? Child10To19Ypresent { get; set; }

    public int? BoysCount { get; set; }

    public int? GirlsCounts { get; set; }

    public bool? SchoolC23 { get; set; }

    public bool? IsChildAfter1To8EductionStop { get; set; }

    public string ChildAddreee { get; set; }

    public bool? ChildSipmulkTalim { get; set; }

    public string TalimName { get; set; }

    public bool? AnyViolenceInYourFamily { get; set; }

    public string ViolenceType { get; set; }

    public string ViolenceRegister { get; set; }

    public string LadisRajashwala { get; set; }

    public bool? AnyLadisKamalari { get; set; }

    public bool? AnyUpToThreeYearAnyMarrage { get; set; }

    public bool? AnySunoloPresentDayAama { get; set; }

    public bool? SunoloTimeKahneKuraChalFul { get; set; }

    public bool? AnyCasualtiesDuringCovid { get; set; }

    public int? CasualtiesCount { get; set; }

    public bool? AnyCovidDose { get; set; }

    public bool? OuterMemberPresentInOurFamily { get; set; }

    public string UpacharWhere { get; set; }

    public bool? AnyDisaster { get; set; }

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

    public string IncomeShrotAgriculture { get; set; }

    public string IncomeYearly { get; set; }

    public bool? AnyOtherIncomeSource { get; set; }

    public string OtherIncomeSourceName { get; set; }

    public string OtherIncomeYearly { get; set; }

    public bool? FamilyBusiness { get; set; }

    public int? FamilyBusinessNo { get; set; }

    public bool? FamilyEmployment { get; set; }

    public string FamilyEmploymentName { get; set; }

    public string FamilyEmploymentDuration { get; set; }

    public bool? FamilyProductQuality { get; set; }

    public bool? FamilyProductEnough { get; set; }

    public virtual HouseOwnerDetail HouseOwnerDetail { get; set; }
}
