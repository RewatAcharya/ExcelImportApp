using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public class HouseOwnerDetail
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public int WardNo { get; set; }

    public string Address { get; set; }

    public string HouseNo { get; set; }

    public int? TotalFamilyCount { get; set; }

    public int? MaleFamilyCount { get; set; }

    public int? FemaleFamilyCount { get; set; }

    public int? OtherFamilyCount { get; set; }

    public int? TogetherCount { get; set; }

    public int? TogetherMaleCount { get; set; }

    public int? TogetherFemaleCount { get; set; }

    public int? TogetherOtherCount { get; set; }

    public int? ResidingCount { get; set; }

    public int? ResidingMaleCount { get; set; }

    public int? ResidingFemaleCount { get; set; }

    public int? ResidingOtherCount { get; set; }

    public int? ResidingAbroadCount { get; set; }

    public int? ResidingAbroadMaleCount { get; set; }

    public int? ResidingAbroadFemaleCount { get; set; }

    public int? ResidingAbroadOtherCount { get; set; }

    public int? HouseTypeId { get; set; }

    public bool? IsUnEmployedMember { get; set; }

    public int? SkillTypeId { get; set; }

    public bool? IsAnyBusiness { get; set; }

    public int? BusinessTypeId { get; set; }

    public bool? IsLandLalPurja { get; set; }

    public bool? IsLandOutOfPalika { get; set; }

    public string LandOwner { get; set; }

    public string LandAnna { get; set; }

    public string LandRopani { get; set; }

    public string ChildrenSchoolType { get; set; }

    public int? VehicleId { get; set; }

    public bool? IsNaturalDisasterArea { get; set; }

    public int? NaturalDisasterId { get; set; }

    public int? Earthquake2072Id { get; set; }

    public bool? IsEarthquakeAnudan { get; set; }

    public string EarthquakeKista { get; set; }

    public long? LocalLevelId { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public bool? IsVehicle { get; set; }

    public string ContactNo { get; set; }

    public int? GenderId { get; set; }

    public int? OldWardNo { get; set; }

    public string Photo { get; set; }

    public string GharKoPhoto { get; set; }

    public int? MarriedMan { get; set; }

    public int? UnMarriedMan { get; set; }

    public int? MarriedWoman { get; set; }

    public int? UnMarriedWoman { get; set; }

    public bool? AnyHasFamilyMemberMoved { get; set; }

    public int? SeniorCitizensTotal { get; set; }

    public int? SeniorCitizensMan { get; set; }

    public int? SeniorCitizensWoman { get; set; }

    public int? SeniorCitizensOthers { get; set; }

    public bool? AnySingleWomen { get; set; }

    public int? SingleWomenCount { get; set; }

    public bool? AnyJesthaNagarik { get; set; }

    public bool? AnyDisablePerson { get; set; }

    public int? TotalDisablePerson { get; set; }

    public int? MaleDisablePerson { get; set; }

    public int? FemaleDisablePerson { get; set; }

    public int? OtherDisablePerson { get; set; }

    public bool? CardLinuVayo { get; set; }

    public string KunCardLinuVayo { get; set; }

    public virtual ICollection<AgricultureDetail> AgricultureDetails { get; set; } = new List<AgricultureDetail>();

    public virtual ICollection<BalBibaha> BalBibahas { get; set; } = new List<BalBibaha>();

    public virtual BusinessType BusinessType { get; set; }

    public virtual Earthquake2072 Earthquake2072 { get; set; }

    public virtual ICollection<EconomicDetail> EconomicDetails { get; set; } = new List<EconomicDetail>();

    public virtual ICollection<EducationDetail> EducationDetails { get; set; } = new List<EducationDetail>();

    public virtual Gender Gender { get; set; }

    public virtual ICollection<GharMuliChildDetail> GharMuliChildDetails { get; set; } = new List<GharMuliChildDetail>();

    public virtual ICollection<GharMuliFamilyMarrageDetail> GharMuliFamilyMarrageDetails { get; set; } = new List<GharMuliFamilyMarrageDetail>();

    public virtual ICollection<HealthDetail> HealthDetails { get; set; } = new List<HealthDetail>();

    public virtual ICollection<HouseDetail> HouseDetails { get; set; } = new List<HouseDetail>();

    public virtual ICollection<HouseOwnerAbdhiGroup> HouseOwnerAbdhiGroups { get; set; } = new List<HouseOwnerAbdhiGroup>();

    public virtual ICollection<HouseOwnerCode> HouseOwnerCodes { get; set; } = new List<HouseOwnerCode>();

    public virtual ICollection<HouseOwnerCountryGroup> HouseOwnerCountryGroups { get; set; } = new List<HouseOwnerCountryGroup>();

    public virtual ICollection<HouseOwnerFamilyDetail> HouseOwnerFamilyDetails { get; set; } = new List<HouseOwnerFamilyDetail>();

    public virtual HouseType HouseType { get; set; }

    public virtual LocalLevel LocalLevel { get; set; }

    public virtual ICollection<MovedFamilyMemberDetail> MovedFamilyMemberDetails { get; set; } = new List<MovedFamilyMemberDetail>();

    public virtual ICollection<MultisectoralNutritionAndExtension> MultisectoralNutritionAndExtensions { get; set; } = new List<MultisectoralNutritionAndExtension>();

    public virtual NaturalDisaster NaturalDisaster { get; set; }

    public virtual ICollection<PregnancyDetail> PregnancyDetails { get; set; } = new List<PregnancyDetail>();

    public virtual SkillType SkillType { get; set; }

    public virtual ICollection<SleepMotherDetail> SleepMotherDetails { get; set; } = new List<SleepMotherDetail>();

    public virtual Vehicle Vehicle { get; set; }

    public virtual ICollection<WhereAreTheyNowDetail> WhereAreTheyNowDetails { get; set; } = new List<WhereAreTheyNowDetail>();
}
