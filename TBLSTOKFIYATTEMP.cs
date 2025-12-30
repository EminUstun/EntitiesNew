using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSTOKFIYATTEMP")]
[Index("SUBE_KODU", Name = "IX_TBLSTOKFIYATTEMP_SUBE_KODU")]
public partial class TBLSTOKFIYATTEMP
{
    [Key]
    public int ID { get; set; }

    public string? STOK_KODU { get; set; }

    public string? STOK_ADI { get; set; }

    public double? KULL2N { get; set; }

    public double? KDV_ORANI { get; set; }

    public string? KOD5 { get; set; }

    public double? FIYAT1 { get; set; }

    public double? FIYAT2 { get; set; }

    public double? FIYAT3 { get; set; }

    public double? FIYAT4 { get; set; }

    public double? FIYAT5 { get; set; }

    public double? FIYAT6 { get; set; }

    public double? FIYATA { get; set; }

    public string? GRUP_KODU { get; set; }

    public string? KOD1 { get; set; }

    public double? DEPO { get; set; }

    public double? ALISFIYAT1 { get; set; }

    public double? KONTEYNER_ADET { get; set; }

    public double? NAVLUN_BEDELI_USD { get; set; }

    public double? USD24 { get; set; }

    public string? CREATE_USER { get; set; }

    public DateTime? CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public double? ZAM_ORANI { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSTOKFIYATTEMPs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
