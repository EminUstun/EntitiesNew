using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLMONTAJ")]
[Index("SUBE_KODU", Name = "IX_TBLMONTAJ_SUBE_KODU")]
public partial class TBLMONTAJ
{
    [Key]
    public int ID { get; set; }

    public string STOK_KODU { get; set; } = null!;

    public int DURUM { get; set; }

    public string? ACIKLAMA1 { get; set; }

    public string? ACIKLAMA2 { get; set; }

    public string? ACIKLAMA3 { get; set; }

    public string? CARI_KODU { get; set; }

    public DateTime? PLAN_TARIH { get; set; }

    public DateTime? GERCEKLESME_TARIH { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public double MIKTAR { get; set; }

    public string? TEKNISYEN { get; set; }

    public DateTime? TESLIM_TARIH { get; set; }

    public string TIP { get; set; } = null!;

    public DateTime? ATOLYE_GIRIS_TARIHI { get; set; }

    public string? GARANTI { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLMONTAJs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
