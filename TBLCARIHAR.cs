using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLCARIHAR")]
[Index("SUBE_KODU", "CARI_KODU", "TIP", Name = "IX_TBLCARIHAR_SUBE_KODU_CARI_KODU_TIP")]
[Index("SUBE_KODU", "CARI_KODU", "TIP", "BELGE_NO", Name = "IX_TBLCARIHAR_SUBE_KODU_CARI_KODU_TIP_BELGE_NO")]
public partial class TBLCARIHAR
{
    [Key]
    public int ID { get; set; }

    public int SUBE_KODU { get; set; }

    public string CARI_KODU { get; set; } = null!;

    public DateTime TARIH { get; set; }

    public DateTime VADE_TARIHI { get; set; }

    public string? BELGE_NO { get; set; }

    public string TIP { get; set; } = null!;

    public double BORC { get; set; }

    public double ALACAK { get; set; }

    public string? BAG_NO { get; set; }

    public string? ACIKLAMA { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int DOVIZTIP_ID { get; set; }

    public double? DOV_KUR { get; set; }

    public double? DOV_TUTAR { get; set; }

    public int? MUSTERI_ID { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLCARIHARs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
