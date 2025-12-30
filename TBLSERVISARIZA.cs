using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSERVISARIZA")]
[Index("SUBE_KODU", Name = "IX_TBLSERVISARIZA_SUBE_KODU")]
public partial class TBLSERVISARIZA
{
    [Key]
    public int ID { get; set; }

    public DateTime TARIH { get; set; }

    public bool GARANTI { get; set; }

    public string STOK_KODU { get; set; } = null!;

    public DateTime GARANTI_TARIH { get; set; }

    public string? FAT_NO { get; set; }

    public int SERVIS_DURUM { get; set; }

    public string? SER_ACIKLAMA { get; set; }

    public string MUS_SIKAYET { get; set; } = null!;

    public string? EK_ACIKLAMA { get; set; }

    public int MUSTERI_TIP { get; set; }

    public string? CARI_KODU { get; set; }

    public string? MUSTER_ADI { get; set; }

    public string? MUSTERI_ID { get; set; }

    public string? AD_SOYAD { get; set; }

    public string? TEL_NO { get; set; }

    public string? TEL_NO2 { get; set; }

    public string? BOLGE { get; set; }

    public string? EPOSTA { get; set; }

    public string? ADRES { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string SERI_NUMARASI { get; set; } = null!;

    public DateTime? TESLIM_TARIHI { get; set; }

    public string? TEKNISYEN { get; set; }

    public double FIYAT { get; set; }

    public int SUBE_KODU { get; set; }

    public int MONTAJ_ID { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSERVISARIZAs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
