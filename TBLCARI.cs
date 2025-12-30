using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLCARI")]
[Index("SUBE_KODU", "CARI_KODU", Name = "IX_TBLCARI_SUBE_KODU_CARI_KODU", IsUnique = true)]
public partial class TBLCARI
{
    public int SUBE_KODU { get; set; }

    [Key]
    public string CARI_KODU { get; set; } = null!;

    public string CARI_ADI { get; set; } = null!;

    public string? ADRES { get; set; }

    public string? IL { get; set; }

    public string? ILCE { get; set; }

    public string? TELEFON { get; set; }

    public string? FAX { get; set; }

    public string? EMAIL { get; set; }

    public string? VDAIRE { get; set; }

    public string? VNO { get; set; }

    public string? TCKIMLIK_NO { get; set; }

    public string? DETAY_KODU { get; set; }

    public string CARI_TIP { get; set; } = null!;

    public string FAT_TIP { get; set; } = null!;

    public string? GRUP_KODU { get; set; }

    public string? RAPOR_KODU1 { get; set; }

    public string? RAPOR_KODU2 { get; set; }

    public string? RAPOR_KODU3 { get; set; }

    public string? RAPOR_KODU4 { get; set; }

    public string? RAPOR_KODU5 { get; set; }

    public string? FIYAT_GRUBU { get; set; }

    public int? LISTE_FIYATI { get; set; }

    public double? ISKONTO_ORANI { get; set; }

    public double? VADE_GUNU { get; set; }

    public string? PLA_KODU { get; set; }

    public bool CARI_KILIT { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public double? KULL1N { get; set; }

    public string? KULL1S { get; set; }

    public double? KULL2N { get; set; }

    public string? KULL2S { get; set; }

    public double? KULL3N { get; set; }

    public string? KULL3S { get; set; }

    public double? KULL4N { get; set; }

    public string? KULL4S { get; set; }

    public double? KULL5N { get; set; }

    public string? KULL5S { get; set; }

    public double? KULL6N { get; set; }

    public string? KULL6S { get; set; }

    public double? KULL7N { get; set; }

    public string? KULL7S { get; set; }

    public double? KULL8N { get; set; }

    public string? KULL8S { get; set; }

    public int DOVIZTIP_ID { get; set; }

    public string? CARI_KILIT_ACIKLAMA { get; set; }

    public double ALACAK { get; set; }

    public double BAKIYE { get; set; }

    public double BORC { get; set; }

    public DateTime? SON_ODEME_TARIHI { get; set; }

    public double? SON_ODENEN_TUTAR { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLCARIs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
