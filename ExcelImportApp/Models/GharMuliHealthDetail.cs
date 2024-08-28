using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class GharMuliHealthDetail
{
    public int Id { get; set; }

    public int GharMuliId { get; set; }

    public bool? AnyPregnancy { get; set; }

    public bool? AnySleepMotherInYourHouse { get; set; }

    public bool AnyHivcase { get; set; }

    public bool? IsBornChildHivinfected { get; set; }

    public bool? Arvprophylaxis { get; set; }

    public bool Is12YearChild { get; set; }

    public string ChildKhopDetails { get; set; }

    public bool Is16YearChild { get; set; }

    public bool? IsKhopCard { get; set; }

    public string SixMto5YbitminAkhopPatak { get; set; }

    public string OneTo5YjukaKhopPatak { get; set; }

    public bool Is24Mchaild { get; set; }

    public bool? IsWeighted { get; set; }

    public string HowManyTimes { get; set; }

    public string WeightThau { get; set; }

    public bool AnyChildHealthIssue { get; set; }

    public string HealthIssuColorType { get; set; }

    public string EatNunType { get; set; }

    public bool AnyDiarrheaIssue { get; set; }

    public bool? DiarrheaTimeEatJinkChaki { get; set; }

    public int? DiarrheaTimeEatDays { get; set; }

    public bool? DiarrheaTimeEatPunJaliyaJhol { get; set; }

    public bool IsNotGoToSchool5To14Child { get; set; }

    public string CurrentAddeess { get; set; }

    public bool Child10To19Ypresent { get; set; }

    public int? BoysCount { get; set; }

    public int? GirlsCounts { get; set; }

    public bool SchoolC23 { get; set; }

    public bool? IsChildAfter1To8EductionStop { get; set; }

    public string ChildAddreee { get; set; }

    public bool? ChildSipmulkTalim { get; set; }

    public string TalimName { get; set; }

    public bool? AnyViolenceInYourFamily { get; set; }

    public string ViolenceType { get; set; }

    public string ViolenceRegister { get; set; }

    public string LadisRajashwala { get; set; }

    public bool? AnyLadisKamalari { get; set; }

    public bool AnyUpToThreeYearAnyMarrage { get; set; }

    public bool AnySunoloPresentDayAama { get; set; }

    public bool? SunoloTimeKahneKuraChalFul { get; set; }

    public bool AnyCasualtiesDuringCovid { get; set; }

    public int? CasualtiesCount { get; set; }

    public bool AnyCovidDose { get; set; }

    public bool OuterMemberPresentInOurFamily { get; set; }

    public virtual GharMuliDetail GharMuli { get; set; }
}
