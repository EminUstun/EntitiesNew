using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TMPBORC")]
[Index("SUBE_KODU", Name = "IX_TMPBORC_SUBE_KODU")]
public partial class TMPBORC
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

    public int TAK_ID { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TMPBORCs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
