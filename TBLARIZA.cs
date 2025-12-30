using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLARIZA")]
[Index("SUBE_KODU", Name = "IX_TBLARIZA_SUBE_KODU")]
public partial class TBLARIZA
{
    [Key]
    public int ID { get; set; }

    public string MUSTERI_ADSOYAD { get; set; } = null!;

    public string MUSTERI_BOLGE { get; set; } = null!;

    public string? MUSTERI_ADRES { get; set; }

    public string MUSTERI_TELEFON { get; set; } = null!;

    public string STOK_KODU { get; set; } = null!;

    public string? STOK_SERINO { get; set; }

    public double MIKTAR { get; set; }

    public string? RAF_NO { get; set; }

    public string MUSTERI_SIKAYETI { get; set; } = null!;

    public string? SERVIS_ACIKLAMA { get; set; }

    public DateTime GIRIS_TARIHI { get; set; }

    public DateTime? SERVIS_GONDERIM_TARIHI { get; set; }

    public DateTime? SERVIS_GELIS_TARIHI { get; set; }

    public DateTime? MUSTERI_TESLIM_TARIHI { get; set; }

    public string KABUL_EDEN { get; set; } = null!;

    public string? SERVISE_GONDEREN { get; set; }

    public string? SERVISTEN_ALAN { get; set; }

    public string? TESLIM_EDEN { get; set; }

    public string DURUM { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string? SERVIS_PERSONELI { get; set; }

    public bool GARANTI_DURUM { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? UCRET { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLARIZAs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
