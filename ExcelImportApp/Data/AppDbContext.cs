using ExcelImportApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ExcelImportApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Table1> Table1s { get; set; }
        public DbSet<HouseOwnerDetail> HouseOwnerDetails { get; set; }
        public DbSet<MovedFamilyMemberDetail> MovedFamilyMemberDetails { get; set; }
        public DbSet<HouseOwnerCountryGroup> HouseOwnerCountryGroups { get; set; }
        public DbSet<HouseOwnerAbdhiGroup> HouseOwnerAbdhiGroups { get; set; }

        public DbSet<Ward> Wards { get; set; }
        public DbSet<HouseOwnerCode> HouseOwnerCodes { get; set; }



        public DbSet<Abhadhi> Abhadhis { get; set; }

        public DbSet<AdhyanKunTaha> AdhyanKunTahas { get; set; }

        public DbSet<AgeGroup> AgeGroups { get; set; }

        public DbSet<AgricultureDetail> AgricultureDetails { get; set; }

        public DbSet<AgricultureDetailAnimalGroup> AgricultureDetailAnimalGroups { get; set; }

        public DbSet<AgriculturePasuPanchiDetail> AgriculturePasuPanchiDetails { get; set; }

        public DbSet<AgricultureProductDetail> AgricultureProductDetails { get; set; }

        public DbSet<AgricultureProductQuantity> AgricultureProductQuantities { get; set; }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<Animal> Animals { get; set; }

        public DbSet<ArthikBarsaSetup> ArthikBarsaSetups { get; set; }

        public DbSet<AspNetRole> AspNetRoles { get; set; }

        public DbSet<AspNetUser> AspNetUsers { get; set; }

        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

        public DbSet<Atm> Atms { get; set; }

        public DbSet<AverageMonthlyIncome> AverageMonthlyIncomes { get; set; }

        public DbSet<AverageMonthlySaving> AverageMonthlySavings { get; set; }

        public DbSet<BalBibaha> BalBibahas { get; set; }

        public DbSet<BalbalikaKgarxan> BalbalikaKgarxans { get; set; }

        public DbSet<BiheKanuniSamasya> BiheKanuniSamasyas { get; set; }

        public DbSet<BiheKasariVayeko> BiheKasariVayekos { get; set; }

        public DbSet<BihePaxiSamasya> BihePaxiSamasyas { get; set; }

        public DbSet<BihePaxiSankyuktum> BihePaxiSankyukta { get; set; }

        public DbSet<BloodBank> BloodBanks { get; set; }

        public DbSet<BusinessType> BusinessTypes { get; set; }

        public DbSet<Caste> Castes { get; set; }

        public DbSet<ChronicDisease> ChronicDiseases { get; set; }

        public DbSet<ChuloPrakar> ChuloPrakars { get; set; }

        public DbSet<CitizenshipType> CitizenshipTypes { get; set; }

        public DbSet<CookingFuel> CookingFuels { get; set; }

        public DbSet<CookingStove> CookingStoves { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Designation> Designations { get; set; }

        public DbSet<DisabilityCard> DisabilityCards { get; set; }

        public DbSet<DisabilityReason> DisabilityReasons { get; set; }

        public DbSet<DisabilityType> DisabilityTypes { get; set; }

        public DbSet<Disaster> Disasters { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<DistrictDetail> DistrictDetails { get; set; }

        public DbSet<DudhBataBanekoUtpadan> DudhBataBanekoUtpadans { get; set; }

        public DbSet<Earthquake2072> Earthquake2072s { get; set; }

        public DbSet<EconomicDetail> EconomicDetails { get; set; }

        public DbSet<EconomicDetailTechnicalSkillGroup> EconomicDetailTechnicalSkillGroups { get; set; }

        public DbSet<EducationDetail> EducationDetails { get; set; }

        public DbSet<EducationDetailSchoolGroup> EducationDetailSchoolGroups { get; set; }

        public DbSet<EducationEducationalLevelGroup> EducationEducationalLevelGroups { get; set; }

        public DbSet<EducationLevel> EducationLevels { get; set; }

        public DbSet<EducationalLevel> EducationalLevels { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<FoodCondition> FoodConditions { get; set; }

        public DbSet<FreshVegetableFromWhere> FreshVegetableFromWheres { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<GharMuliChildDetail> GharMuliChildDetails { get; set; }

        public DbSet<GharMuliDetail> GharMuliDetails { get; set; }

        public DbSet<GharMuliEconomicStatus> GharMuliEconomicStatuses { get; set; }

        public DbSet<GharMuliFamilyDetail> GharMuliFamilyDetails { get; set; }

        public DbSet<GharMuliFamilyMarrageDetail> GharMuliFamilyMarrageDetails { get; set; }

        public DbSet<GharMuliHealthDetail> GharMuliHealthDetails { get; set; }

        public DbSet<GharMuliKhanePaniAndAawasDetail> GharMuliKhanePaniAndAawasDetails { get; set; }

        public DbSet<GothPrakar> GothPrakars { get; set; }

        public DbSet<GovernWorkerHelp> GovernWorkerHelps { get; set; }

        public DbSet<HaaatKhutaPaniKasariPrayog> HaaatKhutaPaniKasariPrayogs { get; set; }

        public DbSet<HealthDetail> HealthDetails { get; set; }

        public DbSet<HealthDetailChronicDiseaseGroup> HealthDetailChronicDiseaseGroups { get; set; }

        public DbSet<HealthDetailDisabilityCardGroup> HealthDetailDisabilityCardGroups { get; set; }

        public DbSet<HealthDetailDisabilityReasonGroup> HealthDetailDisabilityReasonGroups { get; set; }

        public DbSet<HealthDetailDisabilityTypeGroup> HealthDetailDisabilityTypeGroups { get; set; }

        public DbSet<HealthFacility> HealthFacilities { get; set; }

        public DbSet<HistoricPlace> HistoricPlaces { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<HouseDetail> HouseDetails { get; set; }

        public DbSet<HouseFloor> HouseFloors { get; set; }

        public DbSet<HouseMapDetail> HouseMapDetails { get; set; }


        public DbSet<HouseOwnerFamilyDetail> HouseOwnerFamilyDetails { get; set; }

        public DbSet<HouseOwnerType> HouseOwnerTypes { get; set; }

        public DbSet<HouseOwnership> HouseOwnerships { get; set; }

        public DbSet<HouseRoof> HouseRoofs { get; set; }

        public DbSet<HouseType> HouseTypes { get; set; }

        public DbSet<HowFast> HowFasts { get; set; }

        public DbSet<HydroPower> HydroPowers { get; set; }

        public DbSet<IncomeSource> IncomeSources { get; set; }

        public DbSet<Industry> Industries { get; set; }

        public DbSet<IndustryDetail> IndustryDetails { get; set; }

        public DbSet<Institution> Institutions { get; set; }

        public DbSet<JanPratinidhi> JanPratinidhis { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<JuthyanNirmanPrakar> JuthyanNirmanPrakars { get; set; }

        public DbSet<KaryalayaSetup> KaryalayaSetups { get; set; }

        public DbSet<KatiDinAntarMeat> KatiDinAntarMeats { get; set; }

        public DbSet<KatiPariman> KatiParimen { get; set; }

        public DbSet<KhaneyPaniShrot> KhaneyPaniShrots { get; set; }

        public DbSet<KhopAwastha> KhopAwasthas { get; set; }

        public DbSet<KunMalPrayog> KunMalPrayogs { get; set; }

        public DbSet<KunNun> KunNuns { get; set; }

        public DbSet<Lake> Lakes { get; set; }

        public DbSet<LandDetail> LandDetails { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<LightSource> LightSources { get; set; }

        public DbSet<LocalLevel> LocalLevels { get; set; }

        public DbSet<LocalLevelDetail> LocalLevelDetails { get; set; }

        public DbSet<MeatFromWhere> MeatFromWheres { get; set; }

        public DbSet<MeatKg> MeatKgs { get; set; }

        public DbSet<Ministry> Ministries { get; set; }

        public DbSet<Mountain> Mountains { get; set; }

        public DbSet<MultisectoralNutritionAndExtension> MultisectoralNutritionAndExtensions { get; set; }

        public DbSet<NagarikWadaPatra> NagarikWadaPatras { get; set; }

        public DbSet<NagarikWadaPatraDoc> NagarikWadaPatraDocs { get; set; }

        public DbSet<NaturalDisaster> NaturalDisasters { get; set; }

        public DbSet<Notice> Notices { get; set; }

        public DbSet<Occupation> Occupations { get; set; }

        public DbSet<OccupationDetail> OccupationDetails { get; set; }

        public DbSet<PeriodHudaKahaBasnuHunxa> PeriodHudaKahaBasnuHunxas { get; set; }

        public DbSet<PersonalEvent> PersonalEvents { get; set; }

        public DbSet<PersonalEventDetail> PersonalEventDetails { get; set; }

        public DbSet<PoliceStation> PoliceStations { get; set; }

        public DbSet<PopulationDetail> PopulationDetails { get; set; }

        public DbSet<PopulationDetailAgeGroup> PopulationDetailAgeGroups { get; set; }

        public DbSet<PopulationDetailCasteGroup> PopulationDetailCasteGroups { get; set; }

        public DbSet<PopulationDetailOccupationGroup> PopulationDetailOccupationGroups { get; set; }

        public DbSet<PrajannaSambandhiSamasya> PrajannaSambandhiSamasyas { get; set; }

        public DbSet<PregnancyDetail> PregnancyDetails { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProtectedArea> ProtectedAreas { get; set; }

        public DbSet<Religion> Religions { get; set; }

        public DbSet<SchoolLayer> SchoolLayers { get; set; }

        public DbSet<SchoolTime> SchoolTimes { get; set; }

        public DbSet<ShikshyaType> ShikshyaTypes { get; set; }

        public DbSet<Sikshya> Sikshyas { get; set; }

        public DbSet<SkillType> SkillTypes { get; set; }

        public DbSet<SleepMotherDetail> SleepMotherDetails { get; set; }

        public DbSet<SocialProgram> SocialPrograms { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<StateDetail> StateDetails { get; set; }

        public DbSet<TaulKatiPatak> TaulKatiPataks { get; set; }

        public DbSet<TaulLineyThau> TaulLineyThaus { get; set; }

        public DbSet<Tax> Taxes { get; set; }

        public DbSet<TaxDetail> TaxDetails { get; set; }

        public DbSet<TechnicalSkill> TechnicalSkills { get; set; }

        public DbSet<ThapKhana> ThapKhanas { get; set; }

        public DbSet<Toilet> Toilets { get; set; }

        public DbSet<ToiletCleaningTime> ToiletCleaningTimes { get; set; }

        public DbSet<TraningType> TraningTypes { get; set; }

        public DbSet<UserDetail> UserDetails { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<ViolenceReport> ViolenceReports { get; set; }

        public DbSet<ViolenceType> ViolenceTypes { get; set; }

        public DbSet<VitAbarshaKatiPatak> VitAbarshaKatiPataks { get; set; }

        public DbSet<WardDetail> WardDetails { get; set; }

        public DbSet<WashingHand> WashingHands { get; set; }

        public DbSet<WasteManagement> WasteManagements { get; set; }

        public DbSet<WaterDetail> WaterDetails { get; set; }

        public DbSet<WaterFall> WaterFalls { get; set; }

        public DbSet<WaterResource> WaterResources { get; set; }

        public DbSet<WhereAreTheyNow> WhereAreTheyNows { get; set; }

        public DbSet<WhereAreTheyNowDetail> WhereAreTheyNowDetails { get; set; }


    }
}
