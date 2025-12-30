using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSTOKFIYAT")]
[Index("FIYAT_GRUBU", "STOK_KODU", "TIP", "SUBE_KODU", Name = "IX_TBLSTOKFIYAT_FIYAT_GRUBU_STOK_KODU_TIP_SUBE_KODU")]
[Index("SUBE_KODU", Name = "IX_TBLSTOKFIYAT_SUBE_KODU")]
public partial class TBLSTOKFIYAT
{
    [Key]
    public int ID { get; set; }

    public int SUBE_KODU { get; set; }

    public string FIYAT_GRUBU { get; set; } = null!;

    public string STOK_KODU { get; set; } = null!;

    public string TIP { get; set; } = null!;

    public string? OLCU_BIRIM { get; set; }

    public double? FIYAT1 { get; set; }

    public double? FIYAT2 { get; set; }

    public double? FIYAT3 { get; set; }

    public double? FIYAT4 { get; set; }

    public double? FIYAT5 { get; set; }

    public double? FIYAT6 { get; set; }

    public double? FIYAT7 { get; set; }

    public double? FIYAT8 { get; set; }

    public double? FIYAT9 { get; set; }

    public double? FIYAT10 { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSTOKFIYATs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
