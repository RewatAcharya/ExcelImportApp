//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace ExcelImportApp.Models;

//public partial class FalelungContext : DbContext
//{
//    public FalelungContext()
//    {
//    }

//    public FalelungContext(DbContextOptions<FalelungContext> options)
//        : base(options)
//    {
//    }

//    public virtual DbSet<Abhadhi> Abhadhis { get; set; }

//    public virtual DbSet<AdhyanKunTaha> AdhyanKunTahas { get; set; }

//    public virtual DbSet<AgeGroup> AgeGroups { get; set; }

//    public virtual DbSet<AgricultureDetail> AgricultureDetails { get; set; }

//    public virtual DbSet<AgricultureDetailAnimalGroup> AgricultureDetailAnimalGroups { get; set; }

//    public virtual DbSet<AgriculturePasuPanchiDetail> AgriculturePasuPanchiDetails { get; set; }

//    public virtual DbSet<AgricultureProductDetail> AgricultureProductDetails { get; set; }

//    public virtual DbSet<AgricultureProductQuantity> AgricultureProductQuantities { get; set; }

//    public virtual DbSet<Airport> Airports { get; set; }

//    public virtual DbSet<Animal> Animals { get; set; }

//    public virtual DbSet<ArthikBarsaSetup> ArthikBarsaSetups { get; set; }

//    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

//    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

//    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

//    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

//    public virtual DbSet<Atm> Atms { get; set; }

//    public virtual DbSet<AverageMonthlyIncome> AverageMonthlyIncomes { get; set; }

//    public virtual DbSet<AverageMonthlySaving> AverageMonthlySavings { get; set; }

//    public virtual DbSet<BalBibaha> BalBibahas { get; set; }

//    public virtual DbSet<BalbalikaKgarxan> BalbalikaKgarxans { get; set; }

//    public virtual DbSet<BiheKanuniSamasya> BiheKanuniSamasyas { get; set; }

//    public virtual DbSet<BiheKasariVayeko> BiheKasariVayekos { get; set; }

//    public virtual DbSet<BihePaxiSamasya> BihePaxiSamasyas { get; set; }

//    public virtual DbSet<BihePaxiSankyuktum> BihePaxiSankyukta { get; set; }

//    public virtual DbSet<BloodBank> BloodBanks { get; set; }

//    public virtual DbSet<BusinessType> BusinessTypes { get; set; }

//    public virtual DbSet<Caste> Castes { get; set; }

//    public virtual DbSet<ChronicDisease> ChronicDiseases { get; set; }

//    public virtual DbSet<ChuloPrakar> ChuloPrakars { get; set; }

//    public virtual DbSet<CitizenshipType> CitizenshipTypes { get; set; }

//    public virtual DbSet<CookingFuel> CookingFuels { get; set; }

//    public virtual DbSet<CookingStove> CookingStoves { get; set; }

//    public virtual DbSet<Country> Countries { get; set; }

//    public virtual DbSet<Department> Departments { get; set; }

//    public virtual DbSet<Designation> Designations { get; set; }

//    public virtual DbSet<DisabilityCard> DisabilityCards { get; set; }

//    public virtual DbSet<DisabilityReason> DisabilityReasons { get; set; }

//    public virtual DbSet<DisabilityType> DisabilityTypes { get; set; }

//    public virtual DbSet<Disaster> Disasters { get; set; }

//    public virtual DbSet<District> Districts { get; set; }

//    public virtual DbSet<DistrictDetail> DistrictDetails { get; set; }

//    public virtual DbSet<DudhBataBanekoUtpadan> DudhBataBanekoUtpadans { get; set; }

//    public virtual DbSet<Earthquake2072> Earthquake2072s { get; set; }

//    public virtual DbSet<EconomicDetail> EconomicDetails { get; set; }

//    public virtual DbSet<EconomicDetailTechnicalSkillGroup> EconomicDetailTechnicalSkillGroups { get; set; }

//    public virtual DbSet<EducationDetail> EducationDetails { get; set; }

//    public virtual DbSet<EducationDetailSchoolGroup> EducationDetailSchoolGroups { get; set; }

//    public virtual DbSet<EducationEducationalLevelGroup> EducationEducationalLevelGroups { get; set; }

//    public virtual DbSet<EducationLevel> EducationLevels { get; set; }

//    public virtual DbSet<EducationalLevel> EducationalLevels { get; set; }

//    public virtual DbSet<Employee> Employees { get; set; }

//    public virtual DbSet<FoodCondition> FoodConditions { get; set; }

//    public virtual DbSet<FreshVegetableFromWhere> FreshVegetableFromWheres { get; set; }

//    public virtual DbSet<Gender> Genders { get; set; }

//    public virtual DbSet<GharMuliChildDetail> GharMuliChildDetails { get; set; }

//    public virtual DbSet<GharMuliDetail> GharMuliDetails { get; set; }

//    public virtual DbSet<GharMuliEconomicStatus> GharMuliEconomicStatuses { get; set; }

//    public virtual DbSet<GharMuliFamilyDetail> GharMuliFamilyDetails { get; set; }

//    public virtual DbSet<GharMuliFamilyMarrageDetail> GharMuliFamilyMarrageDetails { get; set; }

//    public virtual DbSet<GharMuliHealthDetail> GharMuliHealthDetails { get; set; }

//    public virtual DbSet<GharMuliKhanePaniAndAawasDetail> GharMuliKhanePaniAndAawasDetails { get; set; }

//    public virtual DbSet<GothPrakar> GothPrakars { get; set; }

//    public virtual DbSet<GovernWorkerHelp> GovernWorkerHelps { get; set; }

//    public virtual DbSet<HaaatKhutaPaniKasariPrayog> HaaatKhutaPaniKasariPrayogs { get; set; }

//    public virtual DbSet<HealthDetail> HealthDetails { get; set; }

//    public virtual DbSet<HealthDetailChronicDiseaseGroup> HealthDetailChronicDiseaseGroups { get; set; }

//    public virtual DbSet<HealthDetailDisabilityCardGroup> HealthDetailDisabilityCardGroups { get; set; }

//    public virtual DbSet<HealthDetailDisabilityReasonGroup> HealthDetailDisabilityReasonGroups { get; set; }

//    public virtual DbSet<HealthDetailDisabilityTypeGroup> HealthDetailDisabilityTypeGroups { get; set; }

//    public virtual DbSet<HealthFacility> HealthFacilities { get; set; }

//    public virtual DbSet<HistoricPlace> HistoricPlaces { get; set; }

//    public virtual DbSet<Hotel> Hotels { get; set; }

//    public virtual DbSet<HouseDetail> HouseDetails { get; set; }

//    public virtual DbSet<HouseFloor> HouseFloors { get; set; }

//    public virtual DbSet<HouseMapDetail> HouseMapDetails { get; set; }

//    public virtual DbSet<HouseOwnerAbdhiGroup> HouseOwnerAbdhiGroups { get; set; }

//    public virtual DbSet<HouseOwnerCode> HouseOwnerCodes { get; set; }

//    public virtual DbSet<HouseOwnerCountryGroup> HouseOwnerCountryGroups { get; set; }

//    public virtual DbSet<HouseOwnerDetail> HouseOwnerDetails { get; set; }

//    public virtual DbSet<HouseOwnerFamilyDetail> HouseOwnerFamilyDetails { get; set; }

//    public virtual DbSet<HouseOwnerType> HouseOwnerTypes { get; set; }

//    public virtual DbSet<HouseOwnership> HouseOwnerships { get; set; }

//    public virtual DbSet<HouseRoof> HouseRoofs { get; set; }

//    public virtual DbSet<HouseType> HouseTypes { get; set; }

//    public virtual DbSet<HowFast> HowFasts { get; set; }

//    public virtual DbSet<HydroPower> HydroPowers { get; set; }

//    public virtual DbSet<IncomeSource> IncomeSources { get; set; }

//    public virtual DbSet<Industry> Industries { get; set; }

//    public virtual DbSet<IndustryDetail> IndustryDetails { get; set; }

//    public virtual DbSet<Institution> Institutions { get; set; }

//    public virtual DbSet<JanPratinidhi> JanPratinidhis { get; set; }

//    public virtual DbSet<Job> Jobs { get; set; }

//    public virtual DbSet<JuthyanNirmanPrakar> JuthyanNirmanPrakars { get; set; }

//    public virtual DbSet<KaryalayaSetup> KaryalayaSetups { get; set; }

//    public virtual DbSet<KatiDinAntarMeat> KatiDinAntarMeats { get; set; }

//    public virtual DbSet<KatiPariman> KatiParimen { get; set; }

//    public virtual DbSet<KhaneyPaniShrot> KhaneyPaniShrots { get; set; }

//    public virtual DbSet<KhopAwastha> KhopAwasthas { get; set; }

//    public virtual DbSet<KunMalPrayog> KunMalPrayogs { get; set; }

//    public virtual DbSet<KunNun> KunNuns { get; set; }

//    public virtual DbSet<Lake> Lakes { get; set; }

//    public virtual DbSet<LandDetail> LandDetails { get; set; }

//    public virtual DbSet<Language> Languages { get; set; }

//    public virtual DbSet<LightSource> LightSources { get; set; }

//    public virtual DbSet<LocalLevel> LocalLevels { get; set; }

//    public virtual DbSet<LocalLevelDetail> LocalLevelDetails { get; set; }

//    public virtual DbSet<MeatFromWhere> MeatFromWheres { get; set; }

//    public virtual DbSet<MeatKg> MeatKgs { get; set; }

//    public virtual DbSet<Ministry> Ministries { get; set; }

//    public virtual DbSet<Mountain> Mountains { get; set; }

//    public virtual DbSet<MovedFamilyMemberDetail> MovedFamilyMemberDetails { get; set; }

//    public virtual DbSet<MultisectoralNutritionAndExtension> MultisectoralNutritionAndExtensions { get; set; }

//    public virtual DbSet<NagarikWadaPatra> NagarikWadaPatras { get; set; }

//    public virtual DbSet<NagarikWadaPatraDoc> NagarikWadaPatraDocs { get; set; }

//    public virtual DbSet<NaturalDisaster> NaturalDisasters { get; set; }

//    public virtual DbSet<Notice> Notices { get; set; }

//    public virtual DbSet<Occupation> Occupations { get; set; }

//    public virtual DbSet<OccupationDetail> OccupationDetails { get; set; }

//    public virtual DbSet<PeriodHudaKahaBasnuHunxa> PeriodHudaKahaBasnuHunxas { get; set; }

//    public virtual DbSet<PersonalEvent> PersonalEvents { get; set; }

//    public virtual DbSet<PersonalEventDetail> PersonalEventDetails { get; set; }

//    public virtual DbSet<PoliceStation> PoliceStations { get; set; }

//    public virtual DbSet<PopulationDetail> PopulationDetails { get; set; }

//    public virtual DbSet<PopulationDetailAgeGroup> PopulationDetailAgeGroups { get; set; }

//    public virtual DbSet<PopulationDetailCasteGroup> PopulationDetailCasteGroups { get; set; }

//    public virtual DbSet<PopulationDetailOccupationGroup> PopulationDetailOccupationGroups { get; set; }

//    public virtual DbSet<PrajannaSambandhiSamasya> PrajannaSambandhiSamasyas { get; set; }

//    public virtual DbSet<PregnancyDetail> PregnancyDetails { get; set; }

//    public virtual DbSet<Project> Projects { get; set; }

//    public virtual DbSet<ProtectedArea> ProtectedAreas { get; set; }

//    public virtual DbSet<Religion> Religions { get; set; }

//    public virtual DbSet<SchoolLayer> SchoolLayers { get; set; }

//    public virtual DbSet<SchoolTime> SchoolTimes { get; set; }

//    public virtual DbSet<ShikshyaType> ShikshyaTypes { get; set; }

//    public virtual DbSet<Sikshya> Sikshyas { get; set; }

//    public virtual DbSet<SkillType> SkillTypes { get; set; }

//    public virtual DbSet<SleepMotherDetail> SleepMotherDetails { get; set; }

//    public virtual DbSet<SocialProgram> SocialPrograms { get; set; }

//    public virtual DbSet<State> States { get; set; }

//    public virtual DbSet<StateDetail> StateDetails { get; set; }

//    public virtual DbSet<TaulKatiPatak> TaulKatiPataks { get; set; }

//    public virtual DbSet<TaulLineyThau> TaulLineyThaus { get; set; }

//    public virtual DbSet<Tax> Taxes { get; set; }

//    public virtual DbSet<TaxDetail> TaxDetails { get; set; }

//    public virtual DbSet<TechnicalSkill> TechnicalSkills { get; set; }

//    public virtual DbSet<ThapKhana> ThapKhanas { get; set; }

//    public virtual DbSet<Toilet> Toilets { get; set; }

//    public virtual DbSet<ToiletCleaningTime> ToiletCleaningTimes { get; set; }

//    public virtual DbSet<TraningType> TraningTypes { get; set; }

//    public virtual DbSet<UserDetail> UserDetails { get; set; }

//    public virtual DbSet<Vehicle> Vehicles { get; set; }

//    public virtual DbSet<ViolenceReport> ViolenceReports { get; set; }

//    public virtual DbSet<ViolenceType> ViolenceTypes { get; set; }

//    public virtual DbSet<VitAbarshaKatiPatak> VitAbarshaKatiPataks { get; set; }

//    public virtual DbSet<Ward> Wards { get; set; }

//    public virtual DbSet<WardDetail> WardDetails { get; set; }

//    public virtual DbSet<WashingHand> WashingHands { get; set; }

//    public virtual DbSet<WasteManagement> WasteManagements { get; set; }

//    public virtual DbSet<WaterDetail> WaterDetails { get; set; }

//    public virtual DbSet<WaterFall> WaterFalls { get; set; }

//    public virtual DbSet<WaterResource> WaterResources { get; set; }

//    public virtual DbSet<WhereAreTheyNow> WhereAreTheyNows { get; set; }

//    public virtual DbSet<WhereAreTheyNowDetail> WhereAreTheyNowDetails { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        => optionsBuilder.UseSqlServer("name=DefaultConnection");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<Abhadhi>(entity =>
//        {
//            entity.ToTable("Abhadhi");

//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(500);
//        });

//        modelBuilder.Entity<AdhyanKunTaha>(entity =>
//        {
//            entity.ToTable("AdhyanKunTaha");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<AgeGroup>(entity =>
//        {
//            entity.ToTable("AgeGroup");

//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(500);
//        });

//        modelBuilder.Entity<AgricultureDetail>(entity =>
//        {
//            entity.ToTable("AgricultureDetail");

//            entity.Property(e => e.ModernAgricultureName).HasMaxLength(500);
//            entity.Property(e => e.ModernAgricultureType).HasMaxLength(500);

//            entity.HasOne(d => d.HouseOwnerDetail).WithMany(p => p.AgricultureDetails)
//                .HasForeignKey(d => d.HouseOwnerDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_AgricultureDetail_HouseOwnerDetails");
//        });

//        modelBuilder.Entity<AgricultureDetailAnimalGroup>(entity =>
//        {
//            entity.ToTable("AgricultureDetailAnimalGroup");

//            entity.HasOne(d => d.AgricultureDetail).WithMany(p => p.AgricultureDetailAnimalGroups)
//                .HasForeignKey(d => d.AgricultureDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_AgricultureDetailAnimalId_AgricultureDetail");

//            entity.HasOne(d => d.Animal).WithMany(p => p.AgricultureDetailAnimalGroups)
//                .HasForeignKey(d => d.AnimalId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_AgricultureDetailAnimalId_Animal");
//        });

//        modelBuilder.Entity<AgriculturePasuPanchiDetail>(entity =>
//        {
//            entity.ToTable("AgriculturePasuPanchiDetail");

//            entity.Property(e => e.Pariman)
//                .HasMaxLength(10)
//                .IsFixedLength();
//            entity.Property(e => e.Type).HasMaxLength(500);

//            entity.HasOne(d => d.AgricultureDetail).WithMany(p => p.AgriculturePasuPanchiDetails)
//                .HasForeignKey(d => d.AgricultureDetailId)
//                .HasConstraintName("FK_AgriculturePasuPanchiDetail_AgricultureDetail");
//        });

//        modelBuilder.Entity<AgricultureProductDetail>(entity =>
//        {
//            entity.ToTable("AgricultureProductDetail");

//            entity.HasOne(d => d.AgricultureDetail).WithMany(p => p.AgricultureProductDetails)
//                .HasForeignKey(d => d.AgricultureDetailId)
//                .HasConstraintName("FK_AgricultureProductDetail_AgricultureDetail");
//        });

//        modelBuilder.Entity<AgricultureProductQuantity>(entity =>
//        {
//            entity.ToTable("AgricultureProductQuantity");

//            entity.HasOne(d => d.AgricultureDetail).WithMany(p => p.AgricultureProductQuantities)
//                .HasForeignKey(d => d.AgricultureDetailId)
//                .HasConstraintName("FK_AgricultureProductQuantity_AgricultureDetail");
//        });

//        modelBuilder.Entity<Airport>(entity =>
//        {
//            entity.ToTable("Airport");

//            entity.Property(e => e.Address).HasMaxLength(250);
//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(250);
//            entity.Property(e => e.PhoneNo)
//                .IsRequired()
//                .HasMaxLength(50);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.Airports)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Airport_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.Airports)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_Airport_Ward");
//        });

//        modelBuilder.Entity<Animal>(entity =>
//        {
//            entity.ToTable("Animal");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<ArthikBarsaSetup>(entity =>
//        {
//            entity.ToTable("ArthikBarsaSetup");

//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(50);
//        });

//        modelBuilder.Entity<AspNetRole>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

//            entity.Property(e => e.Id).HasMaxLength(128);
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(256);
//        });

//        modelBuilder.Entity<AspNetUser>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

//            entity.Property(e => e.Id).HasMaxLength(128);
//            entity.Property(e => e.Email).HasMaxLength(256);
//            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
//            entity.Property(e => e.UserName)
//                .IsRequired()
//                .HasMaxLength(256);

//            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
//                .UsingEntity<Dictionary<string, object>>(
//                    "AspNetUserRole",
//                    r => r.HasOne<AspNetRole>().WithMany()
//                        .HasForeignKey("RoleId")
//                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
//                    l => l.HasOne<AspNetUser>().WithMany()
//                        .HasForeignKey("UserId")
//                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
//                    j =>
//                    {
//                        j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");
//                        j.ToTable("AspNetUserRoles");
//                        j.IndexerProperty<string>("UserId").HasMaxLength(128);
//                        j.IndexerProperty<string>("RoleId").HasMaxLength(128);
//                    });
//        });

//        modelBuilder.Entity<AspNetUserClaim>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

//            entity.Property(e => e.UserId)
//                .IsRequired()
//                .HasMaxLength(128);

//            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
//                .HasForeignKey(d => d.UserId)
//                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
//        });

//        modelBuilder.Entity<AspNetUserLogin>(entity =>
//        {
//            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

//            entity.Property(e => e.LoginProvider).HasMaxLength(128);
//            entity.Property(e => e.ProviderKey).HasMaxLength(128);
//            entity.Property(e => e.UserId).HasMaxLength(128);

//            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
//                .HasForeignKey(d => d.UserId)
//                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
//        });

//        modelBuilder.Entity<Atm>(entity =>
//        {
//            entity.ToTable("Atm");

//            entity.Property(e => e.Address).HasMaxLength(250);
//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(250);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.Atms)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Atm_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.Atms)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_Atm_Ward");
//        });

//        modelBuilder.Entity<AverageMonthlyIncome>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__AverageM__3214EC07B332B75D");

//            entity.ToTable("AverageMonthlyIncome");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<AverageMonthlySaving>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__AverageM__3214EC0741D597FF");

//            entity.ToTable("AverageMonthlySaving");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<BalBibaha>(entity =>
//        {
//            entity.ToTable("BalBibaha");

//            entity.Property(e => e.BalBibahaBareyBichar).HasMaxLength(500);
//            entity.Property(e => e.BalBibahaBareyKehiVannu).HasMaxLength(500);
//            entity.Property(e => e.BalBibahaKoSamasya).HasMaxLength(500);
//            entity.Property(e => e.BiheKasariVayeko).HasMaxLength(100);
//            entity.Property(e => e.ChaVaneyKunTaha).HasMaxLength(100);
//            entity.Property(e => e.ChainaVaneyKaran).HasMaxLength(500);
//            entity.Property(e => e.KastoPrakarBihe).HasMaxLength(50);
//            entity.Property(e => e.KatiSamayeSankyukta).HasMaxLength(50);
//            entity.Property(e => e.KpraptaGarnuVoo)
//                .HasMaxLength(500)
//                .HasColumnName("KPraptaGarnuVoo");
//            entity.Property(e => e.KsamasyaAayo)
//                .HasMaxLength(100)
//                .HasColumnName("KSamasyaAayo");
//            entity.Property(e => e.Vayekovaye).HasMaxLength(50);
//            entity.Property(e => e.YediAayo).HasMaxLength(100);
//            entity.Property(e => e.YediVayeko).HasMaxLength(50);

//            entity.HasOne(d => d.HouseOwnerDetail).WithMany(p => p.BalBibahas)
//                .HasForeignKey(d => d.HouseOwnerDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_BalBibaha_HouseOwnerDetails");
//        });

//        modelBuilder.Entity<BalbalikaKgarxan>(entity =>
//        {
//            entity.ToTable("BalbalikaKGarxan");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<BiheKanuniSamasya>(entity =>
//        {
//            entity.ToTable("BiheKanuniSamasya");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<BiheKasariVayeko>(entity =>
//        {
//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<BihePaxiSamasya>(entity =>
//        {
//            entity.ToTable("BihePaxiSamasya");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<BihePaxiSankyuktum>(entity =>
//        {
//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<BloodBank>(entity =>
//        {
//            entity.ToTable("BloodBank");

//            entity.Property(e => e.Address).HasMaxLength(250);
//            entity.Property(e => e.BloodBankName)
//                .IsRequired()
//                .HasMaxLength(150);
//            entity.Property(e => e.ContactNo).HasMaxLength(50);
//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.BloodBanks)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_BloodBank_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.BloodBanks)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_BloodBank_Ward");
//        });

//        modelBuilder.Entity<BusinessType>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__Business__3214EC079A490942");

//            entity.ToTable("BusinessType");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<Caste>(entity =>
//        {
//            entity.ToTable("Caste");

//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(500);
//        });

//        modelBuilder.Entity<ChronicDisease>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__ChronicD__3214EC0753D09CE4");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<ChuloPrakar>(entity =>
//        {
//            entity.ToTable("ChuloPrakar");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<CitizenshipType>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__Citizens__3214EC07B056C1F9");

//            entity.ToTable("CitizenshipType");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<CookingFuel>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__CookingF__3214EC0743D6C832");

//            entity.ToTable("CookingFuel");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<CookingStove>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__CookingS__3214EC07C2151445");

//            entity.ToTable("CookingStove");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<Country>(entity =>
//        {
//            entity.ToTable("Country");

//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(500);
//        });

//        modelBuilder.Entity<Department>(entity =>
//        {
//            entity.ToTable("Department");

//            entity.Property(e => e.Name).HasMaxLength(150);
//        });

//        modelBuilder.Entity<Designation>(entity =>
//        {
//            entity.ToTable("Designation");

//            entity.Property(e => e.Name).HasMaxLength(150);

//            entity.HasOne(d => d.Department).WithMany(p => p.Designations)
//                .HasForeignKey(d => d.DepartmentId)
//                .HasConstraintName("FK_Designation_Department");
//        });

//        modelBuilder.Entity<DisabilityCard>(entity =>
//        {
//            entity.ToTable("DisabilityCard");

//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(500);
//        });

//        modelBuilder.Entity<DisabilityReason>(entity =>
//        {
//            entity.ToTable("DisabilityReason");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<DisabilityType>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__Disabili__3214EC078AB64366");

//            entity.ToTable("DisabilityType");

//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(500);
//        });

//        modelBuilder.Entity<Disaster>(entity =>
//        {
//            entity.ToTable("Disaster");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<District>(entity =>
//        {
//            entity.ToTable("District");

//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(150);

//            entity.HasOne(d => d.State).WithMany(p => p.Districts)
//                .HasForeignKey(d => d.StateId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_District_State");
//        });

//        modelBuilder.Entity<DistrictDetail>(entity =>
//        {
//            entity.Property(e => e.Area).HasMaxLength(50);
//            entity.Property(e => e.HeadQuater).HasMaxLength(250);
//            entity.Property(e => e.Pdensity)
//                .HasMaxLength(50)
//                .HasColumnName("PDensity");
//            entity.Property(e => e.Population).HasMaxLength(50);
//            entity.Property(e => e.Website).HasMaxLength(150);

//            entity.HasOne(d => d.Dist).WithMany(p => p.DistrictDetails)
//                .HasForeignKey(d => d.DistId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_DistrictDetails_District");
//        });

//        modelBuilder.Entity<DudhBataBanekoUtpadan>(entity =>
//        {
//            entity.ToTable("DudhBataBanekoUtpadan");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<Earthquake2072>(entity =>
//        {
//            entity.ToTable("Earthquake2072");

//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(500);
//        });

//        modelBuilder.Entity<EconomicDetail>(entity =>
//        {
//            entity.ToTable("EconomicDetail");

//            entity.Property(e => e.KatiJanaSanglagna).HasColumnName("katiJanaSanglagna");

//            entity.HasOne(d => d.AverageMonthlyIncome).WithMany(p => p.EconomicDetails)
//                .HasForeignKey(d => d.AverageMonthlyIncomeId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_EconomicDetail_AverageMonthlyIncome");

//            entity.HasOne(d => d.FoodCondition).WithMany(p => p.EconomicDetails)
//                .HasForeignKey(d => d.FoodConditionId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_EconomicDetail_FoodCondition");

//            entity.HasOne(d => d.HouseOwnerDetail).WithMany(p => p.EconomicDetails)
//                .HasForeignKey(d => d.HouseOwnerDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_EconomicDetail_HouseOwnerDetails");
//        });

//        modelBuilder.Entity<EconomicDetailTechnicalSkillGroup>(entity =>
//        {
//            entity.ToTable("EconomicDetailTechnicalSkillGroup");

//            entity.HasOne(d => d.EconomicDetail).WithMany(p => p.EconomicDetailTechnicalSkillGroups)
//                .HasForeignKey(d => d.EconomicDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_EconomicDetailTechnicalSkillGroup_EconomicDetail");

//            entity.HasOne(d => d.TechnicalSkill).WithMany(p => p.EconomicDetailTechnicalSkillGroups)
//                .HasForeignKey(d => d.TechnicalSkillId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_EconomicDetailTechnicalSkillGroup_TechnicalSkills");
//        });

//        modelBuilder.Entity<EducationDetail>(entity =>
//        {
//            entity.ToTable("EducationDetail");

//            entity.Property(e => e.AnyViolenceOccurredYourChild).HasMaxLength(500);
//            entity.Property(e => e.RegisterCaseAddress).HasMaxLength(500);
//            entity.Property(e => e.StayAddress).HasMaxLength(500);
//            entity.Property(e => e.VocationalTraningName).HasMaxLength(500);

//            entity.HasOne(d => d.HouseOwnerDetail).WithMany(p => p.EducationDetails)
//                .HasForeignKey(d => d.HouseOwnerDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_EducationDetail_HouseOwnerDetails");

//            entity.HasOne(d => d.WhereAreTheyNow).WithMany(p => p.EducationDetails)
//                .HasForeignKey(d => d.WhereAreTheyNowId)
//                .HasConstraintName("FK_EducationDetail_WhereAreTheyNow");
//        });

//        modelBuilder.Entity<EducationDetailSchoolGroup>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_HealthDetailSchoolGroup");

//            entity.ToTable("EducationDetailSchoolGroup");

//            entity.HasOne(d => d.Education).WithMany(p => p.EducationDetailSchoolGroups)
//                .HasForeignKey(d => d.EducationId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_EducationDetailSchoolGroup_EducationDetail");

//            entity.HasOne(d => d.SchoolLayer).WithMany(p => p.EducationDetailSchoolGroups)
//                .HasForeignKey(d => d.SchoolLayerId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_EducationDetailSchoolGroup_SchoolLayer");

//            entity.HasOne(d => d.SchoolTime).WithMany(p => p.EducationDetailSchoolGroups)
//                .HasForeignKey(d => d.SchoolTimeId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_EducationDetailSchoolGroup_SchoolTime");
//        });

//        modelBuilder.Entity<EducationEducationalLevelGroup>(entity =>
//        {
//            entity.ToTable("EducationEducationalLevelGroup");

//            entity.HasOne(d => d.Education).WithMany(p => p.EducationEducationalLevelGroups)
//                .HasForeignKey(d => d.EducationId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_EducationEducationalLevelGroup_EducationDetail");

//            entity.HasOne(d => d.EducationalLevel).WithMany(p => p.EducationEducationalLevelGroups)
//                .HasForeignKey(d => d.EducationalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_EducationEducationalLevelGroup_EducationalLevel");
//        });

//        modelBuilder.Entity<EducationLevel>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__Educatio__3214EC0781ECE833");

//            entity.ToTable("EducationLevel");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<EducationalLevel>(entity =>
//        {
//            entity.ToTable("EducationalLevel");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<Employee>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_Eployee");

//            entity.ToTable("Employee");

//            entity.Property(e => e.Address).HasMaxLength(150);
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(250);
//            entity.Property(e => e.Phone).HasMaxLength(50);

//            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
//                .HasForeignKey(d => d.DepartmentId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Eployee_Department");

//            entity.HasOne(d => d.Designation).WithMany(p => p.Employees)
//                .HasForeignKey(d => d.DesignationId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Employee_Designation");

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.Employees)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Eployee_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.Employees)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_Eployee_Ward");
//        });

//        modelBuilder.Entity<FoodCondition>(entity =>
//        {
//            entity.ToTable("FoodCondition");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<FreshVegetableFromWhere>(entity =>
//        {
//            entity.ToTable("FreshVegetableFromWhere");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<Gender>(entity =>
//        {
//            entity.ToTable("Gender");

//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(250);
//            entity.Property(e => e.NameEng).HasMaxLength(250);
//        });

//        modelBuilder.Entity<GharMuliChildDetail>(entity =>
//        {
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(500);
//            entity.Property(e => e.Remarks).HasMaxLength(500);

//            entity.HasOne(d => d.GharMuli).WithMany(p => p.GharMuliChildDetails)
//                .HasForeignKey(d => d.GharMuliId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_GharMuliChildDetails_GharMuliDetails");
//        });

//        modelBuilder.Entity<GharMuliDetail>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_GahrMuliDetails");

//            entity.Property(e => e.ContactNo).HasMaxLength(50);
//            entity.Property(e => e.GharNo).HasMaxLength(50);
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(500);
//            entity.Property(e => e.OldWardNo).HasMaxLength(50);
//            entity.Property(e => e.Village).HasMaxLength(500);

//            entity.HasOne(d => d.Caste).WithMany(p => p.GharMuliDetails)
//                .HasForeignKey(d => d.CasteId)
//                .HasConstraintName("FK_GahrMuliDetails_Caste");

//            entity.HasOne(d => d.Gender).WithMany(p => p.GharMuliDetails)
//                .HasForeignKey(d => d.GenderId)
//                .HasConstraintName("FK_GahrMuliDetails_Gender");

//            entity.HasOne(d => d.Language).WithMany(p => p.GharMuliDetails)
//                .HasForeignKey(d => d.LanguageId)
//                .HasConstraintName("FK_GahrMuliDetails_Language");

//            entity.HasOne(d => d.Religion).WithMany(p => p.GharMuliDetails)
//                .HasForeignKey(d => d.ReligionId)
//                .HasConstraintName("FK_GahrMuliDetails_Religion");

//            entity.HasOne(d => d.Ward).WithMany(p => p.GharMuliDetails)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_GahrMuliDetails_Ward");
//        });

//        modelBuilder.Entity<GharMuliEconomicStatus>(entity =>
//        {
//            entity.ToTable("GharMuliEconomicStatus");

//            entity.Property(e => e.AnyOtherIncomeSource).HasColumnName("AnyOtherIncome_Source");
//            entity.Property(e => e.FamilyEmploymentDuration)
//                .HasMaxLength(500)
//                .HasColumnName("FamilyEmployment_Duration");
//            entity.Property(e => e.FamilyEmploymentName).HasMaxLength(500);
//            entity.Property(e => e.FamilyProductEnough).HasColumnName("Family_ProductEnough");
//            entity.Property(e => e.FamilyProductQuality).HasColumnName("Family_ProductQuality");
//            entity.Property(e => e.IncomeShrotAgriculture)
//                .HasMaxLength(500)
//                .HasColumnName("IncomeShrot_Agriculture");
//            entity.Property(e => e.IncomeYearly)
//                .HasColumnType("decimal(18, 2)")
//                .HasColumnName("Income_Yearly");
//            entity.Property(e => e.OtherIncomeSourceName).HasMaxLength(500);
//            entity.Property(e => e.OtherIncomeYearly).HasColumnType("decimal(18, 2)");

//            entity.HasOne(d => d.GharMuli).WithMany(p => p.GharMuliEconomicStatuses)
//                .HasForeignKey(d => d.GharMuliId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_GharMuliEconomicStatus_GharMuliDetails");
//        });

//        modelBuilder.Entity<GharMuliFamilyDetail>(entity =>
//        {
//            entity.Property(e => e.Dob)
//                .HasMaxLength(50)
//                .HasColumnName("DOB");
//            entity.Property(e => e.Dobeng)
//                .HasColumnType("datetime")
//                .HasColumnName("DOBEng");
//            entity.Property(e => e.Height).HasMaxLength(50);
//            entity.Property(e => e.Job).HasMaxLength(500);
//            entity.Property(e => e.Name).HasMaxLength(500);
//            entity.Property(e => e.Nata).HasMaxLength(500);
//            entity.Property(e => e.Weight).HasMaxLength(50);

//            entity.HasOne(d => d.EducationLevel).WithMany(p => p.GharMuliFamilyDetails)
//                .HasForeignKey(d => d.EducationLevelId)
//                .HasConstraintName("FK_GharMuliFamilyDetails_EducationalLevel");

//            entity.HasOne(d => d.GharMuli).WithMany(p => p.GharMuliFamilyDetails)
//                .HasForeignKey(d => d.GharMuliId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_GharMuliFamilyDetails_GahrMuliDetails");
//        });

//        modelBuilder.Entity<GharMuliFamilyMarrageDetail>(entity =>
//        {
//            entity.Property(e => e.FullName)
//                .IsRequired()
//                .HasMaxLength(500);
//            entity.Property(e => e.MarrageDate)
//                .IsRequired()
//                .HasMaxLength(50);
//            entity.Property(e => e.MarrageDateEng).HasColumnType("datetime");

//            entity.HasOne(d => d.Gender).WithMany(p => p.GharMuliFamilyMarrageDetails)
//                .HasForeignKey(d => d.GenderId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_GharMuliFamilyMarrageDetails_Gender");

//            entity.HasOne(d => d.GharMuli).WithMany(p => p.GharMuliFamilyMarrageDetails)
//                .HasForeignKey(d => d.GharMuliId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_GharMuliFamilyMarrageDetails_GharMuliDetails");
//        });

//        modelBuilder.Entity<GharMuliHealthDetail>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_Table_1");

//            entity.Property(e => e.AnyHivcase).HasColumnName("AnyHIVCase");
//            entity.Property(e => e.Arvprophylaxis).HasColumnName("ARVProphylaxis");
//            entity.Property(e => e.Child10To19Ypresent).HasColumnName("Child10To19YPresent");
//            entity.Property(e => e.ChildAddreee).HasMaxLength(500);
//            entity.Property(e => e.ChildKhopDetails).HasMaxLength(500);
//            entity.Property(e => e.CurrentAddeess).HasMaxLength(500);
//            entity.Property(e => e.EatNunType).HasMaxLength(500);
//            entity.Property(e => e.HealthIssuColorType).HasMaxLength(500);
//            entity.Property(e => e.HowManyTimes).HasMaxLength(500);
//            entity.Property(e => e.Is24Mchaild).HasColumnName("Is24MChaild");
//            entity.Property(e => e.IsBornChildHivinfected).HasColumnName("IsBornChildHIVInfected");
//            entity.Property(e => e.LadisRajashwala).HasMaxLength(500);
//            entity.Property(e => e.OneTo5YjukaKhopPatak)
//                .HasMaxLength(500)
//                .HasColumnName("OneTo5YJukaKhopPatak");
//            entity.Property(e => e.SixMto5YbitminAkhopPatak)
//                .HasMaxLength(500)
//                .HasColumnName("SixMTo5YBitminAKhopPatak");
//            entity.Property(e => e.TalimName).HasMaxLength(500);
//            entity.Property(e => e.ViolenceRegister).HasMaxLength(500);
//            entity.Property(e => e.ViolenceType).HasMaxLength(500);
//            entity.Property(e => e.WeightThau).HasMaxLength(500);

//            entity.HasOne(d => d.GharMuli).WithMany(p => p.GharMuliHealthDetails)
//                .HasForeignKey(d => d.GharMuliId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_GharMuliHealthDetails_GharMuliDetails");
//        });

//        modelBuilder.Entity<GharMuliKhanePaniAndAawasDetail>(entity =>
//        {
//            entity.Property(e => e.AnimalHouseType).HasMaxLength(500);
//            entity.Property(e => e.ChemicalFertilizerName).HasMaxLength(500);
//            entity.Property(e => e.ConssumeEggCount).HasMaxLength(50);
//            entity.Property(e => e.ConssumeEggsTime).HasMaxLength(500);
//            entity.Property(e => e.CooperativeType).HasMaxLength(500);
//            entity.Property(e => e.DisasterType).HasMaxLength(500);
//            entity.Property(e => e.DrinkingWaterQualityCheckDate).HasMaxLength(50);
//            entity.Property(e => e.DrinkingWaterQualityCheckTime).HasMaxLength(50);
//            entity.Property(e => e.DrinkingWaterShrot).HasMaxLength(500);
//            entity.Property(e => e.FeedBackForEmployee).HasMaxLength(500);
//            entity.Property(e => e.FeedbackAboutHealthcareEmployee).HasMaxLength(500);
//            entity.Property(e => e.FloodDisasterjachDate).HasMaxLength(50);
//            entity.Property(e => e.HealthCareService).HasMaxLength(50);
//            entity.Property(e => e.HouseRentType).HasMaxLength(500);
//            entity.Property(e => e.HowToAvilableFreshVegitable).HasMaxLength(500);
//            entity.Property(e => e.HowToCookFood).HasMaxLength(500);
//            entity.Property(e => e.KaresabariArea).HasMaxLength(500);
//            entity.Property(e => e.MassuConsumeInKg)
//                .HasMaxLength(50)
//                .HasColumnName("MassuConsumeInKG");
//            entity.Property(e => e.MassuCossumeDays).HasMaxLength(500);
//            entity.Property(e => e.MassuShrot).HasMaxLength(500);
//            entity.Property(e => e.MilkAndMilkProductLiter).HasMaxLength(50);
//            entity.Property(e => e.MilkAndMilkProductMedium).HasMaxLength(500);
//            entity.Property(e => e.MilkInLiter).HasMaxLength(50);
//            entity.Property(e => e.OfficeService).HasMaxLength(500);
//            entity.Property(e => e.SabunPaniLeHandWashBani).HasMaxLength(500);
//            entity.Property(e => e.SellMillInLiter).HasMaxLength(50);
//            entity.Property(e => e.ToilatType).HasMaxLength(500);
//            entity.Property(e => e.ToliteCleaningTime).HasMaxLength(500);
//            entity.Property(e => e.UsedWaterUseForOtherUseType).HasMaxLength(500);

//            entity.HasOne(d => d.GharMuli).WithMany(p => p.GharMuliKhanePaniAndAawasDetails)
//                .HasForeignKey(d => d.GharMuliId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_GharMuliKhanePaniAndAawasDetails_GharMuliDetails");
//        });

//        modelBuilder.Entity<GothPrakar>(entity =>
//        {
//            entity.ToTable("GothPrakar");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<GovernWorkerHelp>(entity =>
//        {
//            entity.ToTable("GovernWorkerHelp");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<HaaatKhutaPaniKasariPrayog>(entity =>
//        {
//            entity.ToTable("HaaatKhutaPaniKasariPrayog");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<HealthDetail>(entity =>
//        {
//            entity.ToTable("HealthDetail");

//            entity.Property(e => e.UpacharWhere).HasMaxLength(500);

//            entity.HasOne(d => d.HouseOwnerDetail).WithMany(p => p.HealthDetails)
//                .HasForeignKey(d => d.HouseOwnerDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HealthDetail_HouseOwnerDetails");
//        });

//        modelBuilder.Entity<HealthDetailChronicDiseaseGroup>(entity =>
//        {
//            entity.ToTable("HealthDetailChronicDiseaseGroup");

//            entity.Property(e => e.HealthDetailIid).HasColumnName("HealthDetailIId");

//            entity.HasOne(d => d.ChronicDisease).WithMany(p => p.HealthDetailChronicDiseaseGroups)
//                .HasForeignKey(d => d.ChronicDiseaseId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HealthDetailChronicDiseaseGroup_ChronicDiseases");

//            entity.HasOne(d => d.HealthDetailI).WithMany(p => p.HealthDetailChronicDiseaseGroups)
//                .HasForeignKey(d => d.HealthDetailIid)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HealthDetailChronicDiseaseGroup_HealthDetail");
//        });

//        modelBuilder.Entity<HealthDetailDisabilityCardGroup>(entity =>
//        {
//            entity.ToTable("HealthDetailDisabilityCardGroup");

//            entity.HasOne(d => d.DisabilityCard).WithMany(p => p.HealthDetailDisabilityCardGroups)
//                .HasForeignKey(d => d.DisabilityCardId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HealthDetailDisabilityCardGroup_DisabilityCard");

//            entity.HasOne(d => d.HealthDetail).WithMany(p => p.HealthDetailDisabilityCardGroups)
//                .HasForeignKey(d => d.HealthDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HealthDetailDisabilityCardGroup_HealthDetail");
//        });

//        modelBuilder.Entity<HealthDetailDisabilityReasonGroup>(entity =>
//        {
//            entity.ToTable("HealthDetailDisabilityReasonGroup");

//            entity.HasOne(d => d.DisabilityReason).WithMany(p => p.HealthDetailDisabilityReasonGroups)
//                .HasForeignKey(d => d.DisabilityReasonId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HealthDetailDisabilityReasonGroup_DisabilityReason");

//            entity.HasOne(d => d.HealthDetail).WithMany(p => p.HealthDetailDisabilityReasonGroups)
//                .HasForeignKey(d => d.HealthDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HealthDetailDisabilityReasonGroup_HealthDetail");
//        });

//        modelBuilder.Entity<HealthDetailDisabilityTypeGroup>(entity =>
//        {
//            entity.ToTable("HealthDetailDisabilityTypeGroup");

//            entity.HasOne(d => d.DisabilityType).WithMany(p => p.HealthDetailDisabilityTypeGroups)
//                .HasForeignKey(d => d.DisabilityTypeId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HealthDetailDisabilityTypeGroup_DisabilityType");

//            entity.HasOne(d => d.HealthDetail).WithMany(p => p.HealthDetailDisabilityTypeGroups)
//                .HasForeignKey(d => d.HealthDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HealthDetailDisabilityTypeGroup_HealthDetail");
//        });

//        modelBuilder.Entity<HealthFacility>(entity =>
//        {
//            entity.ToTable("HealthFacility");

//            entity.Property(e => e.Address).HasMaxLength(250);
//            entity.Property(e => e.ContactNo).HasMaxLength(50);
//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Name).HasMaxLength(150);
//            entity.Property(e => e.Type).HasMaxLength(50);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.HealthFacilities)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HealthFacility_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.HealthFacilities)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_HealthFacility_Ward");
//        });

//        modelBuilder.Entity<HistoricPlace>(entity =>
//        {
//            entity.ToTable("HistoricPlace");

//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(250);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.HistoricPlaces)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HistoricPlace_Ward");
//        });

//        modelBuilder.Entity<Hotel>(entity =>
//        {
//            entity.ToTable("Hotel");

//            entity.Property(e => e.Address).HasMaxLength(250);
//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(150);
//            entity.Property(e => e.PhoneNo).HasMaxLength(50);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.Hotels)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Hotel_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.Hotels)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_Hotel_Ward");
//        });

//        modelBuilder.Entity<HouseDetail>(entity =>
//        {
//            entity.ToTable("HouseDetail");

//            entity.HasOne(d => d.HouseFloor).WithMany(p => p.HouseDetails)
//                .HasForeignKey(d => d.HouseFloorId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HouseDetail_HouseFloor");

//            entity.HasOne(d => d.HouseMap).WithMany(p => p.HouseDetails)
//                .HasForeignKey(d => d.HouseMapId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HouseDetail_HouseMapDetail");

//            entity.HasOne(d => d.HouseOwnerDetail).WithMany(p => p.HouseDetails)
//                .HasForeignKey(d => d.HouseOwnerDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HouseDetail_HouseOwnerDetails");

//            entity.HasOne(d => d.HouseOwnership).WithMany(p => p.HouseDetails)
//                .HasForeignKey(d => d.HouseOwnershipId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HouseDetail_HouseOwnership");

//            entity.HasOne(d => d.HouseRoof).WithMany(p => p.HouseDetails)
//                .HasForeignKey(d => d.HouseRoofId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HouseDetail_HouseRoof");
//        });

//        modelBuilder.Entity<HouseFloor>(entity =>
//        {
//            entity.ToTable("HouseFloor");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<HouseMapDetail>(entity =>
//        {
//            entity.ToTable("HouseMapDetail");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<HouseOwnerAbdhiGroup>(entity =>
//        {
//            entity.ToTable("HouseOwnerAbdhiGroup");

//            entity.HasOne(d => d.Abhadhi).WithMany(p => p.HouseOwnerAbdhiGroups)
//                .HasForeignKey(d => d.AbhadhiId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HouseOwnerAbdhiGroup_Abhadhi");

//            entity.HasOne(d => d.HouseOwner).WithMany(p => p.HouseOwnerAbdhiGroups)
//                .HasForeignKey(d => d.HouseOwnerId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HouseOwnerAbdhiGroup_HouseOwnerDetails");
//        });

//        modelBuilder.Entity<HouseOwnerCode>(entity =>
//        {
//            entity.ToTable("HouseOwnerCode");

//            entity.HasOne(d => d.HouseOwner).WithMany(p => p.HouseOwnerCodes)
//                .HasForeignKey(d => d.HouseOwnerId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HouseOwnerCode_HouseOwnerDetails");

//            entity.HasOne(d => d.LocalLavel).WithMany(p => p.HouseOwnerCodes)
//                .HasForeignKey(d => d.LocalLavelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HouseOwnerCode_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.HouseOwnerCodes)
//                .HasForeignKey(d => d.WardId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HouseOwnerCode_Ward");
//        });

//        modelBuilder.Entity<HouseOwnerCountryGroup>(entity =>
//        {
//            entity.ToTable("HouseOwnerCountryGroup");

//            entity.HasOne(d => d.Country).WithMany(p => p.HouseOwnerCountryGroups)
//                .HasForeignKey(d => d.CountryId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HouseOwnerCountryGroup_Country");

//            entity.HasOne(d => d.HouseOwner).WithMany(p => p.HouseOwnerCountryGroups)
//                .HasForeignKey(d => d.HouseOwnerId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HouseOwnerCountryGroup_HouseOwnerDetails");
//        });

//        modelBuilder.Entity<HouseOwnerDetail>(entity =>
//        {
//            entity.Property(e => e.ChildrenSchoolType)
//                .IsRequired()
//                .HasMaxLength(500);
//            entity.Property(e => e.ContactNo).HasMaxLength(50);
//            entity.Property(e => e.HouseNo).HasMaxLength(50);
//            entity.Property(e => e.LandAnna)
//                .IsRequired()
//                .HasMaxLength(50);
//            entity.Property(e => e.LandOwner).HasMaxLength(500);
//            entity.Property(e => e.LandRopani)
//                .IsRequired()
//                .HasMaxLength(50);
//            entity.Property(e => e.Name).IsRequired();
//            entity.Property(e => e.Type).HasMaxLength(150);

//            entity.HasOne(d => d.BusinessType).WithMany(p => p.HouseOwnerDetails)
//                .HasForeignKey(d => d.BusinessTypeId)
//                .HasConstraintName("FK_HouseOwnerDetails_BusinessType");

//            entity.HasOne(d => d.Earthquake2072).WithMany(p => p.HouseOwnerDetails)
//                .HasForeignKey(d => d.Earthquake2072Id)
//                .HasConstraintName("FK_HouseOwnerDetails_Earthquake2072");

//            entity.HasOne(d => d.Gender).WithMany(p => p.HouseOwnerDetails)
//                .HasForeignKey(d => d.GenderId)
//                .HasConstraintName("FK_HouseOwnerDetails_Gender");

//            entity.HasOne(d => d.HouseType).WithMany(p => p.HouseOwnerDetails)
//                .HasForeignKey(d => d.HouseTypeId)
//                .HasConstraintName("FK_HouseOwnerDetails_HouseType");

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.HouseOwnerDetails)
//                .HasForeignKey(d => d.LocalLevelId)
//                .HasConstraintName("FK_HouseOwnerDetails_LocalLevel");

//            entity.HasOne(d => d.NaturalDisaster).WithMany(p => p.HouseOwnerDetails)
//                .HasForeignKey(d => d.NaturalDisasterId)
//                .HasConstraintName("FK_HouseOwnerDetails_NaturalDisaster");

//            entity.HasOne(d => d.SkillType).WithMany(p => p.HouseOwnerDetails)
//                .HasForeignKey(d => d.SkillTypeId)
//                .HasConstraintName("FK_HouseOwnerDetails_SkillType");

//            entity.HasOne(d => d.Vehicle).WithMany(p => p.HouseOwnerDetails)
//                .HasForeignKey(d => d.VehicleId)
//                .HasConstraintName("FK_HouseOwnerDetails_Vehicle");
//        });

//        modelBuilder.Entity<HouseOwnerFamilyDetail>(entity =>
//        {
//            entity.Property(e => e.Dob)
//                .HasMaxLength(50)
//                .HasColumnName("DOB");
//            entity.Property(e => e.Dobeng)
//                .HasColumnType("datetime")
//                .HasColumnName("DOBEng");
//            entity.Property(e => e.Height).HasMaxLength(50);
//            entity.Property(e => e.Job).HasMaxLength(500);
//            entity.Property(e => e.Name).HasMaxLength(500);
//            entity.Property(e => e.Nata).HasMaxLength(500);
//            entity.Property(e => e.Weight).HasMaxLength(50);

//            entity.HasOne(d => d.HouseOwnerDetails).WithMany(p => p.HouseOwnerFamilyDetails)
//                .HasForeignKey(d => d.HouseOwnerDetailsId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HouseOwnerFamilyDetails_HouseOwnerDetails");
//        });

//        modelBuilder.Entity<HouseOwnerType>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__HouseOwn__3214EC07903015B7");

//            entity.ToTable("HouseOwnerType");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<HouseOwnership>(entity =>
//        {
//            entity.ToTable("HouseOwnership");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<HouseRoof>(entity =>
//        {
//            entity.ToTable("HouseRoof");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<HouseType>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__HouseTyp__3214EC07406FA76D");

//            entity.ToTable("HouseType");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<HowFast>(entity =>
//        {
//            entity.ToTable("HowFast");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<HydroPower>(entity =>
//        {
//            entity.ToTable("HydroPower");

//            entity.Property(e => e.Address).HasMaxLength(250);
//            entity.Property(e => e.Capacity).HasMaxLength(50);
//            entity.Property(e => e.HydroStatus).HasMaxLength(50);
//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Name).HasMaxLength(250);
//            entity.Property(e => e.PhoneNo).HasMaxLength(50);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.HydroPowers)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_HydroPower_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.HydroPowers)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_HydroPower_Ward");
//        });

//        modelBuilder.Entity<IncomeSource>(entity =>
//        {
//            entity.ToTable("IncomeSource");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<Industry>(entity =>
//        {
//            entity.ToTable("Industry");

//            entity.Property(e => e.Address).HasMaxLength(150);
//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Name).HasMaxLength(150);
//            entity.Property(e => e.PhoneNo).HasMaxLength(50);

//            entity.HasOne(d => d.Ward).WithMany(p => p.Industries)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_Industry_LocalLevel");
//        });

//        modelBuilder.Entity<IndustryDetail>(entity =>
//        {
//            entity.ToTable("IndustryDetail");
//        });

//        modelBuilder.Entity<Institution>(entity =>
//        {
//            entity.ToTable("Institution");

//            entity.HasOne(d => d.WardNoNavigation).WithMany(p => p.Institutions)
//                .HasForeignKey(d => d.WardNo)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Institution_Ward");
//        });

//        modelBuilder.Entity<JanPratinidhi>(entity =>
//        {
//            entity.ToTable("JanPratinidhi");

//            entity.Property(e => e.Desiganation).HasMaxLength(50);
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(150);
//            entity.Property(e => e.PhoneNo).HasMaxLength(50);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.JanPratinidhis)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_JanPratinidhi_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.JanPratinidhis)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_JanPratinidhi_Ward");
//        });

//        modelBuilder.Entity<Job>(entity =>
//        {
//            entity.ToTable("Job");

//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(50);
//        });

//        modelBuilder.Entity<JuthyanNirmanPrakar>(entity =>
//        {
//            entity.ToTable("JuthyanNirmanPrakar");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<KaryalayaSetup>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_Karyalaya");

//            entity.ToTable("KaryalayaSetup");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Address)
//                .IsRequired()
//                .HasMaxLength(500);
//            entity.Property(e => e.Contact)
//                .IsRequired()
//                .HasMaxLength(50);
//            entity.Property(e => e.Email)
//                .IsRequired()
//                .HasMaxLength(500);
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(500);

//            entity.HasOne(d => d.District).WithMany(p => p.KaryalayaSetups)
//                .HasForeignKey(d => d.DistrictId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_KaryalayaSetup_District");

//            entity.HasOne(d => d.Palika).WithMany(p => p.KaryalayaSetups)
//                .HasForeignKey(d => d.PalikaId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_KaryalayaSetup_LocalLevel");

//            entity.HasOne(d => d.Province).WithMany(p => p.KaryalayaSetups)
//                .HasForeignKey(d => d.ProvinceId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_KaryalayaSetup_State");
//        });

//        modelBuilder.Entity<KatiDinAntarMeat>(entity =>
//        {
//            entity.ToTable("KatiDinAntarMeat");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<KatiPariman>(entity =>
//        {
//            entity.ToTable("KatiPariman");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<KhaneyPaniShrot>(entity =>
//        {
//            entity.ToTable("KhaneyPaniShrot");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<KhopAwastha>(entity =>
//        {
//            entity.ToTable("KhopAwastha");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<KunMalPrayog>(entity =>
//        {
//            entity.ToTable("KunMalPrayog");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<KunNun>(entity =>
//        {
//            entity.ToTable("KunNun");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<Lake>(entity =>
//        {
//            entity.ToTable("Lake");

//            entity.Property(e => e.Address).HasMaxLength(250);
//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Name).HasMaxLength(150);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.Lakes)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Lake_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.Lakes)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_Lake_Ward");
//        });

//        modelBuilder.Entity<LandDetail>(entity =>
//        {
//            entity.ToTable("LandDetail");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<Language>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__Language__3214EC074FFECA13");

//            entity.ToTable("Language");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<LightSource>(entity =>
//        {
//            entity.ToTable("LightSource");

//            entity.Property(e => e.Name).HasMaxLength(50);
//        });

//        modelBuilder.Entity<LocalLevel>(entity =>
//        {
//            entity.ToTable("LocalLevel");

//            entity.Property(e => e.Name).HasMaxLength(150);
//            entity.Property(e => e.Type).HasMaxLength(50);

//            entity.HasOne(d => d.Dist).WithMany(p => p.LocalLevels)
//                .HasForeignKey(d => d.DistId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_LocalLevel_District");
//        });

//        modelBuilder.Entity<LocalLevelDetail>(entity =>
//        {
//            entity.Property(e => e.Area).HasMaxLength(50);
//            entity.Property(e => e.Code).HasMaxLength(150);
//            entity.Property(e => e.Density).HasMaxLength(150);
//            entity.Property(e => e.Population).HasMaxLength(50);
//            entity.Property(e => e.Website).HasMaxLength(150);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.LocalLevelDetails)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_LocalLevelDetails_LocalLevel");
//        });

//        modelBuilder.Entity<MeatFromWhere>(entity =>
//        {
//            entity.ToTable("MeatFromWhere");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<MeatKg>(entity =>
//        {
//            entity.ToTable("MeatKg");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<Ministry>(entity =>
//        {
//            entity.ToTable("Ministry");

//            entity.Property(e => e.ContactNumber).HasMaxLength(50);
//            entity.Property(e => e.GovermentType).HasMaxLength(50);
//            entity.Property(e => e.MinisterEmail)
//                .HasMaxLength(50)
//                .IsUnicode(false);
//            entity.Property(e => e.MinisterName).HasMaxLength(150);
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(150);
//            entity.Property(e => e.PartyName).HasMaxLength(150);
//            entity.Property(e => e.StartDate).HasMaxLength(50);

//            entity.HasOne(d => d.State).WithMany(p => p.Ministries)
//                .HasForeignKey(d => d.StateId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Ministry_State");
//        });

//        modelBuilder.Entity<Mountain>(entity =>
//        {
//            entity.ToTable("Mountain");

//            entity.Property(e => e.Address).HasMaxLength(250);
//            entity.Property(e => e.Height).HasMaxLength(50);
//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Name).HasMaxLength(150);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.Mountains)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Mountain_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.Mountains)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_Mountain_Ward");
//        });

//        modelBuilder.Entity<MovedFamilyMemberDetail>(entity =>
//        {
//            entity.Property(e => e.Address).HasMaxLength(500);
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(500);
//            entity.Property(e => e.Remarks).HasMaxLength(500);

//            entity.HasOne(d => d.HouseOwnerDetails).WithMany(p => p.MovedFamilyMemberDetails)
//                .HasForeignKey(d => d.HouseOwnerDetailsId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_MovedFamilyMemberDetails_HouseOwnerDetails");
//        });

//        modelBuilder.Entity<MultisectoralNutritionAndExtension>(entity =>
//        {
//            entity.ToTable("MultisectoralNutritionAndExtension");

//            entity.Property(e => e.AnimalHouseType).HasMaxLength(500);
//            entity.Property(e => e.AnyHivcase).HasColumnName("AnyHIVCase");
//            entity.Property(e => e.AnyOtherIncomeSource).HasColumnName("AnyOtherIncome_Source");
//            entity.Property(e => e.Arvprophylaxis).HasColumnName("ARVProphylaxis");
//            entity.Property(e => e.ChemicalFertilizerName).HasMaxLength(500);
//            entity.Property(e => e.Child10To19Ypresent).HasColumnName("Child10To19YPresent");
//            entity.Property(e => e.ChildAddreee).HasMaxLength(500);
//            entity.Property(e => e.ChildKhopDetails).HasMaxLength(500);
//            entity.Property(e => e.ConssumeEggCount).HasMaxLength(50);
//            entity.Property(e => e.ConssumeEggsTime).HasMaxLength(500);
//            entity.Property(e => e.CooperativeType).HasMaxLength(500);
//            entity.Property(e => e.CurrentAddeess).HasMaxLength(500);
//            entity.Property(e => e.DisasterType).HasMaxLength(500);
//            entity.Property(e => e.DrinkingWaterQualityCheckDate).HasMaxLength(50);
//            entity.Property(e => e.DrinkingWaterQualityCheckTime).HasMaxLength(50);
//            entity.Property(e => e.DrinkingWaterShrot).HasMaxLength(500);
//            entity.Property(e => e.EatNunType).HasMaxLength(500);
//            entity.Property(e => e.FamilyEmploymentDuration)
//                .HasMaxLength(500)
//                .HasColumnName("FamilyEmployment_Duration");
//            entity.Property(e => e.FamilyEmploymentName).HasMaxLength(500);
//            entity.Property(e => e.FamilyProductEnough).HasColumnName("Family_ProductEnough");
//            entity.Property(e => e.FamilyProductQuality).HasColumnName("Family_ProductQuality");
//            entity.Property(e => e.FeedBackForEmployee).HasMaxLength(500);
//            entity.Property(e => e.FeedbackAboutHealthcareEmployee).HasMaxLength(500);
//            entity.Property(e => e.FloodDisasterjachDate).HasMaxLength(50);
//            entity.Property(e => e.HealthCareService).HasMaxLength(50);
//            entity.Property(e => e.HealthIssuColorType).HasMaxLength(500);
//            entity.Property(e => e.HouseRentType).HasMaxLength(500);
//            entity.Property(e => e.HowManyTimes).HasMaxLength(500);
//            entity.Property(e => e.HowToAvilableFreshVegitable).HasMaxLength(500);
//            entity.Property(e => e.HowToCookFood).HasMaxLength(500);
//            entity.Property(e => e.IncomeShrotAgriculture)
//                .HasMaxLength(500)
//                .HasColumnName("IncomeShrot_Agriculture");
//            entity.Property(e => e.IncomeYearly)
//                .HasMaxLength(500)
//                .HasColumnName("Income_Yearly");
//            entity.Property(e => e.Is24Mchaild).HasColumnName("Is24MChaild");
//            entity.Property(e => e.IsBornChildHivinfected).HasColumnName("IsBornChildHIVInfected");
//            entity.Property(e => e.KaresabariArea).HasMaxLength(500);
//            entity.Property(e => e.LadisRajashwala).HasMaxLength(500);
//            entity.Property(e => e.MassuConsumeInKg)
//                .HasMaxLength(50)
//                .HasColumnName("MassuConsumeInKG");
//            entity.Property(e => e.MassuCossumeDays).HasMaxLength(500);
//            entity.Property(e => e.MassuShrot).HasMaxLength(500);
//            entity.Property(e => e.MilkAndMilkProductLiter).HasMaxLength(50);
//            entity.Property(e => e.MilkAndMilkProductMedium).HasMaxLength(500);
//            entity.Property(e => e.MilkInLiter).HasMaxLength(50);
//            entity.Property(e => e.OfficeService).HasMaxLength(500);
//            entity.Property(e => e.OneTo5YjukaKhopPatak)
//                .HasMaxLength(500)
//                .HasColumnName("OneTo5YJukaKhopPatak");
//            entity.Property(e => e.OtherIncomeSourceName).HasMaxLength(500);
//            entity.Property(e => e.OtherIncomeYearly).HasMaxLength(500);
//            entity.Property(e => e.SabunPaniLeHandWashBani).HasMaxLength(500);
//            entity.Property(e => e.SellMillInLiter).HasMaxLength(50);
//            entity.Property(e => e.SixMto5YbitminAkhopPatak)
//                .HasMaxLength(500)
//                .HasColumnName("SixMTo5YBitminAKhopPatak");
//            entity.Property(e => e.TalimName).HasMaxLength(500);
//            entity.Property(e => e.ThapKhanaKhuwaunu).HasMaxLength(500);
//            entity.Property(e => e.ToilatType).HasMaxLength(500);
//            entity.Property(e => e.ToliteCleaningTime).HasMaxLength(500);
//            entity.Property(e => e.UpacharWhere).HasMaxLength(500);
//            entity.Property(e => e.UsedWaterUseForOtherUseType).HasMaxLength(500);
//            entity.Property(e => e.ViolenceRegister).HasMaxLength(500);
//            entity.Property(e => e.ViolenceType).HasMaxLength(500);
//            entity.Property(e => e.WeightThau).HasMaxLength(500);

//            entity.HasOne(d => d.HouseOwnerDetail).WithMany(p => p.MultisectoralNutritionAndExtensions)
//                .HasForeignKey(d => d.HouseOwnerDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_MultisectoralNutritionAndExtension_HouseOwnerDetails");
//        });

//        modelBuilder.Entity<NagarikWadaPatra>(entity =>
//        {
//            entity.ToTable("NagarikWadaPatra");

//            entity.Property(e => e.Charge).HasMaxLength(50);
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(250);
//            entity.Property(e => e.Process).HasMaxLength(250);
//            entity.Property(e => e.TimeRequired).HasMaxLength(50);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.NagarikWadaPatras)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_NagarikWadaPatra_LocalLevel");
//        });

//        modelBuilder.Entity<NagarikWadaPatraDoc>(entity =>
//        {
//            entity.ToTable("NagarikWadaPatraDoc");

//            entity.Property(e => e.Name).HasMaxLength(250);

//            entity.HasOne(d => d.NagarikWadaPatra).WithMany(p => p.NagarikWadaPatraDocs)
//                .HasForeignKey(d => d.NagarikWadaPatraId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_NagarikWadaPatraDoc_NagarikWadaPatra");
//        });

//        modelBuilder.Entity<NaturalDisaster>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__NaturalD__3214EC07718303D4");

//            entity.ToTable("NaturalDisaster");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<Notice>(entity =>
//        {
//            entity.ToTable("Notice");

//            entity.Property(e => e.Date).HasMaxLength(50);
//            entity.Property(e => e.Name).IsRequired();

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.Notices)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Notice_LocalLevel");
//        });

//        modelBuilder.Entity<Occupation>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__Occupati__3214EC076A16A2DB");

//            entity.ToTable("Occupation");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<OccupationDetail>(entity =>
//        {
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(50);
//        });

//        modelBuilder.Entity<PeriodHudaKahaBasnuHunxa>(entity =>
//        {
//            entity.ToTable("PeriodHudaKahaBasnuHunxa");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<PersonalEvent>(entity =>
//        {
//            entity.ToTable("PersonalEvent");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//        });

//        modelBuilder.Entity<PersonalEventDetail>(entity =>
//        {
//            entity.ToTable("PersonalEventDetail");

//            entity.Property(e => e.WadaNo).HasColumnName("Wada_No");
//        });

//        modelBuilder.Entity<PoliceStation>(entity =>
//        {
//            entity.ToTable("PoliceStation");

//            entity.Property(e => e.Address).HasMaxLength(150);
//            entity.Property(e => e.ContactNo).HasMaxLength(50);
//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Name).HasMaxLength(150);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.PoliceStations)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_PoliceStation_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.PoliceStations)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_PoliceStation_Ward");
//        });

//        modelBuilder.Entity<PopulationDetail>(entity =>
//        {
//            entity.ToTable("PopulationDetail");

//            entity.HasOne(d => d.Language).WithMany(p => p.PopulationDetails)
//                .HasForeignKey(d => d.LanguageId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_PopulationDetail_Language");

//            entity.HasOne(d => d.Religion).WithMany(p => p.PopulationDetails)
//                .HasForeignKey(d => d.ReligionId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_PopulationDetail_Religion");
//        });

//        modelBuilder.Entity<PopulationDetailAgeGroup>(entity =>
//        {
//            entity.ToTable("PopulationDetailAgeGroup");

//            entity.HasOne(d => d.AgeGroup).WithMany(p => p.PopulationDetailAgeGroups)
//                .HasForeignKey(d => d.AgeGroupId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_PopulationDetailAgeGroup_AgeGroup");

//            entity.HasOne(d => d.PopulationDetail).WithMany(p => p.PopulationDetailAgeGroups)
//                .HasForeignKey(d => d.PopulationDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_PopulationDetailAgeGroup_PopulationDetail");
//        });

//        modelBuilder.Entity<PopulationDetailCasteGroup>(entity =>
//        {
//            entity.ToTable("PopulationDetailCasteGroup");

//            entity.HasOne(d => d.Caste).WithMany(p => p.PopulationDetailCasteGroups)
//                .HasForeignKey(d => d.CasteId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_PopulationDetailCasteGroup_Caste");

//            entity.HasOne(d => d.Population).WithMany(p => p.PopulationDetailCasteGroups)
//                .HasForeignKey(d => d.PopulationId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_PopulationDetailCasteGroup_PopulationDetail");
//        });

//        modelBuilder.Entity<PopulationDetailOccupationGroup>(entity =>
//        {
//            entity.ToTable("PopulationDetailOccupationGroup");

//            entity.HasOne(d => d.OccupationDetail).WithMany(p => p.PopulationDetailOccupationGroups)
//                .HasForeignKey(d => d.OccupationDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_PopulationDetailOccupationGroup_OccupationDetails");

//            entity.HasOne(d => d.PopulationDetail).WithMany(p => p.PopulationDetailOccupationGroups)
//                .HasForeignKey(d => d.PopulationDetailId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_PopulationDetailOccupationGroup_PopulationDetail");
//        });

//        modelBuilder.Entity<PrajannaSambandhiSamasya>(entity =>
//        {
//            entity.ToTable("PrajannaSambandhiSamasya");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<PregnancyDetail>(entity =>
//        {
//            entity.Property(e => e.AmmaKoNam)
//                .IsRequired()
//                .HasMaxLength(500);
//            entity.Property(e => e.GarvPrachianPatak).HasMaxLength(500);
//            entity.Property(e => e.Ttkhopa)
//                .HasMaxLength(500)
//                .HasColumnName("TTKhopa");
//            entity.Property(e => e.WhatDoUeat).HasColumnName("WhatDoUEat");

//            entity.HasOne(d => d.GharMuli).WithMany(p => p.PregnancyDetails)
//                .HasForeignKey(d => d.GharMuliId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_PregnancyDetails_HouseOwnerDetails");
//        });

//        modelBuilder.Entity<Project>(entity =>
//        {
//            entity.ToTable("Project");

//            entity.Property(e => e.AcceptedDate).HasMaxLength(50);
//            entity.Property(e => e.BenefitFamilyNo).HasMaxLength(50);
//            entity.Property(e => e.Budget).HasMaxLength(50);
//            entity.Property(e => e.CommitteeHeadName).HasMaxLength(150);
//            entity.Property(e => e.CommitteeHeadPhoneNo).HasMaxLength(50);
//            entity.Property(e => e.CommitteeName).HasMaxLength(150);
//            entity.Property(e => e.CompletionDate).HasMaxLength(50);
//            entity.Property(e => e.Name).HasMaxLength(150);
//            entity.Property(e => e.PercentageOfWorkDone).HasMaxLength(50);
//            entity.Property(e => e.StartDate).HasMaxLength(50);
//            entity.Property(e => e.Status).HasMaxLength(50);
//            entity.Property(e => e.ThekdarName).HasMaxLength(50);
//            entity.Property(e => e.ThekdarPhoneNo).HasMaxLength(50);
//            entity.Property(e => e.Type).HasMaxLength(50);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.Projects)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Project_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.Projects)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_Project_Ward");
//        });

//        modelBuilder.Entity<ProtectedArea>(entity =>
//        {
//            entity.ToTable("ProtectedArea");

//            entity.Property(e => e.Address).HasMaxLength(150);
//            entity.Property(e => e.Area).HasMaxLength(50);
//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Name).HasMaxLength(150);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.ProtectedAreas)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_ProtectedArea_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.ProtectedAreas)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_ProtectedArea_Ward");
//        });

//        modelBuilder.Entity<Religion>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__Religion__3214EC07CB58829B");

//            entity.ToTable("Religion");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<SchoolLayer>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_StudentLayer");

//            entity.ToTable("SchoolLayer");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<SchoolTime>(entity =>
//        {
//            entity.ToTable("SchoolTime");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<ShikshyaType>(entity =>
//        {
//            entity.ToTable("ShikshyaType");

//            entity.Property(e => e.Name).HasMaxLength(150);
//        });

//        modelBuilder.Entity<Sikshya>(entity =>
//        {
//            entity.ToTable("Sikshya");

//            entity.Property(e => e.Address).HasMaxLength(250);
//            entity.Property(e => e.ContactNo).HasMaxLength(50);
//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Name).HasMaxLength(250);
//            entity.Property(e => e.Type).HasMaxLength(150);

//            entity.HasOne(d => d.District).WithMany(p => p.Sikshyas)
//                .HasForeignKey(d => d.DistrictId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Sikshya_District");

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.Sikshyas)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Sikshya_LocalLevel");

//            entity.HasOne(d => d.State).WithMany(p => p.Sikshyas)
//                .HasForeignKey(d => d.StateId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Sikshya_State");

//            entity.HasOne(d => d.Ward).WithMany(p => p.Sikshyas)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_Sikshya_Ward");
//        });

//        modelBuilder.Entity<SkillType>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__SkillTyp__3214EC072C015417");

//            entity.ToTable("SkillType");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<SleepMotherDetail>(entity =>
//        {
//            entity.Property(e => e.ChildWeight).HasMaxLength(50);
//            entity.Property(e => e.IranChakkiDays).HasMaxLength(50);
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(500);
//            entity.Property(e => e.PrasutiAddress)
//                .IsRequired()
//                .HasMaxLength(500);
//            entity.Property(e => e.PrasutiJach).HasMaxLength(500);

//            entity.HasOne(d => d.GharMuli).WithMany(p => p.SleepMotherDetails)
//                .HasForeignKey(d => d.GharMuliId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_SleepMotherDetails_HouseOwnerDetails");
//        });

//        modelBuilder.Entity<SocialProgram>(entity =>
//        {
//            entity.ToTable("SocialProgram");

//            entity.Property(e => e.Name)
//                .HasMaxLength(50)
//                .IsUnicode(false);
//        });

//        modelBuilder.Entity<State>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_State_2");

//            entity.ToTable("State");

//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(150);
//        });

//        modelBuilder.Entity<StateDetail>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_State");

//            entity.Property(e => e.Area).HasMaxLength(50);
//            entity.Property(e => e.Capital).HasMaxLength(250);
//            entity.Property(e => e.ChiefMinister).HasMaxLength(150);
//            entity.Property(e => e.Governer).HasMaxLength(250);
//            entity.Property(e => e.Pdensity)
//                .HasMaxLength(50)
//                .HasColumnName("PDensity");
//            entity.Property(e => e.Population).HasMaxLength(50);
//            entity.Property(e => e.Website).HasMaxLength(250);

//            entity.HasOne(d => d.State).WithMany(p => p.StateDetails)
//                .HasForeignKey(d => d.StateId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_StateDetails_State");
//        });

//        modelBuilder.Entity<TaulKatiPatak>(entity =>
//        {
//            entity.ToTable("TaulKatiPatak");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<TaulLineyThau>(entity =>
//        {
//            entity.ToTable("TaulLineyThau");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<Tax>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_Tax_1");

//            entity.ToTable("Tax");

//            entity.Property(e => e.Name).HasMaxLength(250);
//        });

//        modelBuilder.Entity<TaxDetail>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_TaxDetails_1");

//            entity.Property(e => e.Amount).HasMaxLength(50);
//            entity.Property(e => e.Name).HasMaxLength(300);

//            entity.HasOne(d => d.Tax).WithMany(p => p.TaxDetails)
//                .HasForeignKey(d => d.TaxId)
//                .HasConstraintName("FK_TaxDetails_Tax");
//        });

//        modelBuilder.Entity<TechnicalSkill>(entity =>
//        {
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<ThapKhana>(entity =>
//        {
//            entity.ToTable("ThapKhana");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<Toilet>(entity =>
//        {
//            entity.ToTable("Toilet");

//            entity.Property(e => e.Name).HasMaxLength(50);
//        });

//        modelBuilder.Entity<ToiletCleaningTime>(entity =>
//        {
//            entity.ToTable("ToiletCleaningTime");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<TraningType>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__TraningT__3214EC0724E13B4A");

//            entity.ToTable("TraningType");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<UserDetail>(entity =>
//        {
//            entity.Property(e => e.Address).HasMaxLength(150);
//            entity.Property(e => e.Email)
//                .IsRequired()
//                .HasMaxLength(150);
//            entity.Property(e => e.FirstName).HasMaxLength(50);
//            entity.Property(e => e.LastName).HasMaxLength(50);
//            entity.Property(e => e.MiddleName).HasMaxLength(50);
//            entity.Property(e => e.PhoneNo).HasMaxLength(50);

//            entity.HasOne(d => d.District).WithMany(p => p.UserDetails)
//                .HasForeignKey(d => d.DistrictId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_UserDetails_District");

//            entity.HasOne(d => d.LocalLevelNavigation).WithMany(p => p.UserDetails)
//                .HasForeignKey(d => d.LocalLevel)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_UserDetails_LocalLevel");

//            entity.HasOne(d => d.State).WithMany(p => p.UserDetails)
//                .HasForeignKey(d => d.StateId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_UserDetails_State");

//            entity.HasOne(d => d.Ward).WithMany(p => p.UserDetails)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_UserDetails_Ward");
//        });

//        modelBuilder.Entity<Vehicle>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__Vehicle__3214EC0765AD3CA4");

//            entity.ToTable("Vehicle");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<ViolenceReport>(entity =>
//        {
//            entity.ToTable("ViolenceReport");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<ViolenceType>(entity =>
//        {
//            entity.ToTable("ViolenceType");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<VitAbarshaKatiPatak>(entity =>
//        {
//            entity.ToTable("VitABarshaKatiPatak");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<Ward>(entity =>
//        {
//            entity.ToTable("Ward");

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.Wards)
//                .HasForeignKey(d => d.LocalLevelId)
//                .HasConstraintName("FK_Ward_LocalLevel");
//        });

//        modelBuilder.Entity<WardDetail>(entity =>
//        {
//            entity.Property(e => e.Area).HasMaxLength(50);
//            entity.Property(e => e.Density).HasMaxLength(50);
//            entity.Property(e => e.Popullation).HasMaxLength(50);

//            entity.HasOne(d => d.Ward).WithMany(p => p.WardDetails)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_WardDetails_Ward");
//        });

//        modelBuilder.Entity<WashingHand>(entity =>
//        {
//            entity
//                .HasNoKey()
//                .ToTable("WashingHand");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<WasteManagement>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__WasteMan__3214EC07D846A4F1");

//            entity.ToTable("WasteManagement");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<WaterDetail>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK_WaterDetails");

//            entity.ToTable("WaterDetail");
//        });

//        modelBuilder.Entity<WaterFall>(entity =>
//        {
//            entity.ToTable("WaterFall");

//            entity.Property(e => e.Address).HasMaxLength(250);
//            entity.Property(e => e.Height).HasMaxLength(50);
//            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
//            entity.Property(e => e.Name).HasMaxLength(150);

//            entity.HasOne(d => d.LocalLevel).WithMany(p => p.WaterFalls)
//                .HasForeignKey(d => d.LocalLevelId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_WaterFall_LocalLevel");

//            entity.HasOne(d => d.Ward).WithMany(p => p.WaterFalls)
//                .HasForeignKey(d => d.WardId)
//                .HasConstraintName("FK_WaterFall_Ward");
//        });

//        modelBuilder.Entity<WaterResource>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__WaterRes__3214EC07388EF440");

//            entity.ToTable("WaterResource");

//            entity.Property(e => e.Name).HasMaxLength(500);
//        });

//        modelBuilder.Entity<WhereAreTheyNow>(entity =>
//        {
//            entity.ToTable("WhereAreTheyNow");

//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(500);
//        });

//        modelBuilder.Entity<WhereAreTheyNowDetail>(entity =>
//        {
//            entity.Property(e => e.Remarks).HasMaxLength(500);

//            entity.HasOne(d => d.HouseOwnerDetails).WithMany(p => p.WhereAreTheyNowDetails)
//                .HasForeignKey(d => d.HouseOwnerDetailsId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_WhereAreTheyNowDetails_HouseOwnerDetails");

//            entity.HasOne(d => d.WhereAreTheyNow).WithMany(p => p.WhereAreTheyNowDetails)
//                .HasForeignKey(d => d.WhereAreTheyNowId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_WhereAreTheyNowDetails_WhereAreTheyNow");
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
