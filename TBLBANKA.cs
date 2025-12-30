using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLBANKA")]
public partial class TBLBANKA
{
    [Key]
    public string BANKA_KODU { get; set; } = null!;

    public string TCMB_KODU { get; set; } = null!;

    public string? BANKA_ADI { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    [InverseProperty("BANKA_KODUNavigation")]
    public virtual ICollection<TBLBANKAHESAP> TBLBANKAHESAPs { get; set; } = new List<TBLBANKAHESAP>();
}
