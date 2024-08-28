using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class State
{
    public long Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<District> Districts { get; set; } = new List<District>();

    public virtual ICollection<KaryalayaSetup> KaryalayaSetups { get; set; } = new List<KaryalayaSetup>();

    public virtual ICollection<Ministry> Ministries { get; set; } = new List<Ministry>();

    public virtual ICollection<Sikshya> Sikshyas { get; set; } = new List<Sikshya>();

    public virtual ICollection<StateDetail> StateDetails { get; set; } = new List<StateDetail>();

    public virtual ICollection<UserDetail> UserDetails { get; set; } = new List<UserDetail>();
}
