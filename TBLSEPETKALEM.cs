using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSEPETKALEM")]
[Index("SEPET_ID", Name = "IX_TBLSEPETKALEM_SEPET_ID")]
[Index("STOK_KODU", Name = "IX_TBLSEPETKALEM_STOK_KODU")]
[Index("SUBE_KODU", Name = "IX_TBLSEPETKALEM_SUBE_KODU")]
public partial class TBLSEPETKALEM
{
    [Key]
    public int ID { get; set; }

    public int SEPET_ID { get; set; }

    public string STOK_KODU { get; set; } = null!;

    public double MIKTAR { get; set; }

    public double KDV_ORAN { get; set; }

    public double FIYAT { get; set; }

    public string? KAMPANYA_KODU { get; set; }

    public string? ACIKLAMA { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public bool MONTAJ { get; set; }

    public string? GRUP_ID { get; set; }

    public string? SIPARIS_NO { get; set; }

    public int? SIRA { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SEPET_ID")]
    [InverseProperty("TBLSEPETKALEMs")]
    public virtual TBLSEPET SEPET { get; set; } = null!;

    [ForeignKey("STOK_KODU")]
    [InverseProperty("TBLSEPETKALEMs")]
    public virtual TBLSTOK STOK_KODUNavigation { get; set; } = null!;

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSEPETKALEMs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
