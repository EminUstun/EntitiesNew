using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSERVISARIZAMALZEME")]
[Index("SUBE_KODU", Name = "IX_TBLSERVISARIZAMALZEME_SUBE_KODU")]
public partial class TBLSERVISARIZAMALZEME
{
    [Key]
    public int ID { get; set; }

    public string FIS_NO { get; set; } = null!;

    public string? STOK_KODU { get; set; }

    public int? MIKTAR { get; set; }

    public double? FIYAT { get; set; }

    public string? ACIKLAMA { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSERVISARIZAMALZEMEs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
