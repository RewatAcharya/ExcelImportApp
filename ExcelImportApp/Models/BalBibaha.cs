using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class BalBibaha
{
    public int Id { get; set; }

    public int HouseOwnerDetailId { get; set; }

    public bool? Bihe5years { get; set; }

    public string Vayekovaye { get; set; }

    public string BiheKasariVayeko { get; set; }

    public int? ChoraBiheKatiBarsa { get; set; }

    public int? BuhariKoUmer { get; set; }

    public int? ChoriBiheKatiBarsa { get; set; }

    public int? JwaiKoUmer { get; set; }

    public int? Santan { get; set; }

    public string KatiSamayeSankyukta { get; set; }

    public bool? OneBarsaBihe { get; set; }

    public string YediVayeko { get; set; }

    public string KastoPrakarBihe { get; set; }

    public int? BiheGardaUmer { get; set; }

    public bool? Daijo { get; set; }

    public string KpraptaGarnuVoo { get; set; }

    public bool? BihePaxadiAdhyan { get; set; }

    public string ChaVaneyKunTaha { get; set; }

    public string ChainaVaneyKaran { get; set; }

    public bool? UmerNapugiSamasya { get; set; }

    public string KsamasyaAayo { get; set; }

    public bool? BihePaxadiPrajanna { get; set; }

    public string YediAayo { get; set; }

    public bool? YediSanoUmer { get; set; }

    public string AayoVaney { get; set; }

    public string BalBibahaKoSamasya { get; set; }

    public bool? BalBibahaKoBareyThaxa { get; set; }

    public string BalBibahaBareyBichar { get; set; }

    public string BalBibahaBareyKehiVannu { get; set; }

    public int? WardNo { get; set; }

    public virtual HouseOwnerDetail HouseOwnerDetail { get; set; }
}
