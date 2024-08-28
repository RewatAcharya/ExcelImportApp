using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class Ward
{
    public long Id { get; set; }

    public long? WardNo { get; set; }

    public long? LocalLevelId { get; set; }

    public virtual ICollection<Airport> Airports { get; set; } = new List<Airport>();

    public virtual ICollection<Atm> Atms { get; set; } = new List<Atm>();

    public virtual ICollection<BloodBank> BloodBanks { get; set; } = new List<BloodBank>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<GharMuliDetail> GharMuliDetails { get; set; } = new List<GharMuliDetail>();

    public virtual ICollection<HealthFacility> HealthFacilities { get; set; } = new List<HealthFacility>();

    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();

    public virtual ICollection<HouseOwnerCode> HouseOwnerCodes { get; set; } = new List<HouseOwnerCode>();

    public virtual ICollection<HydroPower> HydroPowers { get; set; } = new List<HydroPower>();

    public virtual ICollection<Industry> Industries { get; set; } = new List<Industry>();

    public virtual ICollection<Institution> Institutions { get; set; } = new List<Institution>();

    public virtual ICollection<JanPratinidhi> JanPratinidhis { get; set; } = new List<JanPratinidhi>();

    public virtual ICollection<Lake> Lakes { get; set; } = new List<Lake>();

    public virtual LocalLevel LocalLevel { get; set; }

    public virtual ICollection<Mountain> Mountains { get; set; } = new List<Mountain>();

    public virtual ICollection<PoliceStation> PoliceStations { get; set; } = new List<PoliceStation>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<ProtectedArea> ProtectedAreas { get; set; } = new List<ProtectedArea>();

    public virtual ICollection<Sikshya> Sikshyas { get; set; } = new List<Sikshya>();

    public virtual ICollection<UserDetail> UserDetails { get; set; } = new List<UserDetail>();

    public virtual ICollection<WardDetail> WardDetails { get; set; } = new List<WardDetail>();

    public virtual ICollection<WaterFall> WaterFalls { get; set; } = new List<WaterFall>();
}
