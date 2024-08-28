using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class AgricultureDetail
{
    public int Id { get; set; }

    public bool IsAnyAnimal { get; set; }

    public int? WardNo { get; set; }

    public bool IsLandLalPurja { get; set; }

    public int HouseOwnerDetailId { get; set; }

    public bool? AgricultureLand { get; set; }

    public string AgricultureLandDetail { get; set; }

    public bool? KrishiTathaPasupalanLand { get; set; }

    public bool? PokhariMachapalan { get; set; }

    public bool? SichaiSubidha { get; set; }

    public bool? AgricultureProduct { get; set; }

    public bool? AnimalProduct { get; set; }

    public bool? ModernAgriculture { get; set; }

    public string ModernAgricultureType { get; set; }

    public string ModernAgricultureName { get; set; }

    public bool? CollectionCentre { get; set; }

    public bool? CoolingCenter { get; set; }

    public virtual ICollection<AgricultureDetailAnimalGroup> AgricultureDetailAnimalGroups { get; set; } = new List<AgricultureDetailAnimalGroup>();

    public virtual ICollection<AgriculturePasuPanchiDetail> AgriculturePasuPanchiDetails { get; set; } = new List<AgriculturePasuPanchiDetail>();

    public virtual ICollection<AgricultureProductDetail> AgricultureProductDetails { get; set; } = new List<AgricultureProductDetail>();

    public virtual ICollection<AgricultureProductQuantity> AgricultureProductQuantities { get; set; } = new List<AgricultureProductQuantity>();

    public virtual HouseOwnerDetail HouseOwnerDetail { get; set; }
}
