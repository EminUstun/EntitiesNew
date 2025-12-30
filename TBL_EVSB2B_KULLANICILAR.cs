using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBL_EVSB2B_KULLANICILAR")]
[Index("SUBE_KODU", Name = "IX_TBL_EVSB2B_KULLANICILAR_SUBE_KODU")]
public partial class TBL_EVSB2B_KULLANICILAR
{
    [Key]
    public int ID { get; set; }

    public string? USERNAME { get; set; }

    public string? PASSWORD { get; set; }

    public string? MAIL { get; set; }

    public string? GSM { get; set; }

    public string? UNVAN { get; set; }

    public int? DEPARTMAN { get; set; }

    public int? SUBEKODU { get; set; }

    public string? CARIKODU { get; set; }

    public string? PLASIYERKODU { get; set; }

    public string? STOKGRUP { get; set; }

    public string? STOKGRUP2 { get; set; }

    public int? DEPOKODU { get; set; }

    public string? USTCARI_KODU { get; set; }

    public bool? DURUM { get; set; }

    public string? YETKIACK { get; set; }

    public bool? BAKIM { get; set; }

    public byte[]? AVATAR { get; set; }

    public string? KASA_KODU { get; set; }

    public string? DOGUMTARIHI { get; set; }

    public bool? MAGAZA_KASA { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBL_EVSB2B_KULLANICILARs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
