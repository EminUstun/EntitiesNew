using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLDOVIZTIP")]
[Index("SUBE_KODU", Name = "IX_TBLDOVIZTIP_SUBE_KODU")]
public partial class TBLDOVIZTIP
{
    [Key]
    public int ID { get; set; }

    public string TIP { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string? DOV_KOD { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLDOVIZTIPs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;

    [InverseProperty("DOVIZTIP")]
    public virtual ICollection<TBLBANKAHESAP> TBLBANKAHESAPs { get; set; } = new List<TBLBANKAHESAP>();
}
