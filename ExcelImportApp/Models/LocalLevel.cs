using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class LocalLevel
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public long DistId { get; set; }

    public int? MaxWardNo { get; set; }

    public virtual ICollection<Airport> Airports { get; set; } = new List<Airport>();

    public virtual ICollection<Atm> Atms { get; set; } = new List<Atm>();

    public virtual ICollection<BloodBank> BloodBanks { get; set; } = new List<BloodBank>();

    public virtual District Dist { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<HealthFacility> HealthFacilities { get; set; } = new List<HealthFacility>();

    public virtual ICollection<HistoricPlace> HistoricPlaces { get; set; } = new List<HistoricPlace>();

    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();

    public virtual ICollection<HouseOwnerCode> HouseOwnerCodes { get; set; } = new List<HouseOwnerCode>();

    public virtual ICollection<HouseOwnerDetail> HouseOwnerDetails { get; set; } = new List<HouseOwnerDetail>();

    public virtual ICollection<HydroPower> HydroPowers { get; set; } = new List<HydroPower>();

    public virtual ICollection<JanPratinidhi> JanPratinidhis { get; set; } = new List<JanPratinidhi>();

    public virtual ICollection<KaryalayaSetup> KaryalayaSetups { get; set; } = new List<KaryalayaSetup>();

    public virtual ICollection<Lake> Lakes { get; set; } = new List<Lake>();

    public virtual ICollection<LocalLevelDetail> LocalLevelDetails { get; set; } = new List<LocalLevelDetail>();

    public virtual ICollection<Mountain> Mountains { get; set; } = new List<Mountain>();

    public virtual ICollection<NagarikWadaPatra> NagarikWadaPatras { get; set; } = new List<NagarikWadaPatra>();

    public virtual ICollection<Notice> Notices { get; set; } = new List<Notice>();

    public virtual ICollection<PoliceStation> PoliceStations { get; set; } = new List<PoliceStation>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<ProtectedArea> ProtectedAreas { get; set; } = new List<ProtectedArea>();

    public virtual ICollection<Sikshya> Sikshyas { get; set; } = new List<Sikshya>();

    public virtual ICollection<UserDetail> UserDetails { get; set; } = new List<UserDetail>();

    public virtual ICollection<Ward> Wards { get; set; } = new List<Ward>();

    public virtual ICollection<WaterFall> WaterFalls { get; set; } = new List<WaterFall>();
}
