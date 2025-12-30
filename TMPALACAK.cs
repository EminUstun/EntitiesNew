using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TMPALACAK")]
[Index("SUBE_KODU", Name = "IX_TMPALACAK_SUBE_KODU")]
public partial class TMPALACAK
{
    [Key]
    public long ID { get; set; }

    public string? CARI_KODU { get; set; }

    public DateTime? TARIH { get; set; }

    public string? BELGENO { get; set; }

    public string? ACIKLAMA { get; set; }

    public double? TUTAR { get; set; }

    public double? KAPATILAN_TUTAR { get; set; }

    public double? KALAN { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TMPALACAKs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
