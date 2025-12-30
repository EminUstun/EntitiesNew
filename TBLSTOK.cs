using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSTOK")]
[Index("SUBE_KODU", "STOK_KODU", Name = "IX_TBLSTOK_SUBE_KODU_STOK_KODU", IsUnique = true)]
public partial class TBLSTOK
{
    [Key]
    public string STOK_KODU { get; set; } = null!;

    public int SUBE_KODU { get; set; }

    public string? STOK_ADI { get; set; }

    public double KDV_ORANI { get; set; }

    public string? DETAY_KODU { get; set; }

    public int DEPO_KODU { get; set; }

    public string? OLCU_BIRIMI { get; set; }

    public double AGIRLIK { get; set; }

    public string? ONCEKI_STOK { get; set; }

    public string? SONRAKI_STOK { get; set; }

    public string? BARKOD1 { get; set; }

    public string? BARKOD2 { get; set; }

    public double EN { get; set; }

    public double BOY { get; set; }

    public double YUKSEKLIK { get; set; }

    public string? URETICI_KODU { get; set; }

    public string? GRUP_KODU { get; set; }

    public string? KOD1 { get; set; }

    public string? KOD2 { get; set; }

    public string? KOD3 { get; set; }

    public string? KOD4 { get; set; }

    public string? KOD5 { get; set; }

    public string? KULL1S { get; set; }

    public string? KULL2S { get; set; }

    public string? KULL3S { get; set; }

    public string? KULL4S { get; set; }

    public string? KULL5S { get; set; }

    public string? KULL6S { get; set; }

    public string? KULL7S { get; set; }

    public string? KULL8S { get; set; }

    public double? KULL1N { get; set; }

    public double? KULL2N { get; set; }

    public double? KULL3N { get; set; }

    public double? KULL4N { get; set; }

    public double? KULL5N { get; set; }

    public double? KULL6N { get; set; }

    public double? KULL7N { get; set; }

    public double? KULL8N { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public double? ALIS_FIYAT1 { get; set; }

    public double? ALIS_FIYAT2 { get; set; }

    public double? ALIS_FIYAT3 { get; set; }

    public double? ALIS_FIYAT4 { get; set; }

    public double? SATIS_FIYAT1 { get; set; }

    public double? SATIS_FIYAT2 { get; set; }

    public double? SATIS_FIYAT3 { get; set; }

    public double? SATIS_FIYAT4 { get; set; }

    public double BIRIM_MIKTAR { get; set; }

    public int DOVIZTIP_ID { get; set; }

    public bool DURUM { get; set; }

    public int STOK_TIPI { get; set; }

    public bool SERITAKIP { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSTOKs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;

    [InverseProperty("STOK_KODUNavigation")]
    public virtual ICollection<TBLSEPETKALEM> TBLSEPETKALEMs { get; set; } = new List<TBLSEPETKALEM>();
}
