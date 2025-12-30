using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLBNKHESHAR")]
[Index("SUBE_KODU", Name = "IX_TBLBNKHESHAR_SUBE_KODU")]
public partial class TBLBNKHESHAR
{
    [Key]
    public int ID { get; set; }

    public string HESAP_KODU { get; set; } = null!;

    public DateTime TARIH { get; set; }

    public DateTime VADE_TARIHI { get; set; }

    public string TIPI { get; set; } = null!;

    public string BA { get; set; } = null!;

    public double TUTAR { get; set; }

    public string? ACIKLAMA { get; set; }

    public string? BELGENO { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string? BAG_NO { get; set; }

    public string? KOD { get; set; }

    public int DOVIZTIP_ID { get; set; }

    public double? DOV_KUR { get; set; }

    public double? DOV_TUTAR { get; set; }

    public int SUBE_KODU { get; set; }

    public string? ONAY_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLBNKHESHARs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
