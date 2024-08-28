using System;
using System.Collections.Generic;

namespace ExcelImportApp.Models;

public partial class UserDetail
{
    public long Id { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public string PhoneNo { get; set; }

    public string Email { get; set; }

    public long StateId { get; set; }

    public long DistrictId { get; set; }

    public long LocalLevel { get; set; }

    public string Address { get; set; }

    public long? WardId { get; set; }

    public string Photo { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual District District { get; set; }

    public virtual LocalLevel LocalLevelNavigation { get; set; }

    public virtual State State { get; set; }

    public virtual Ward Ward { get; set; }
}
