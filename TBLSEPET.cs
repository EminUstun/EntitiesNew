using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSEPET")]
[Index("SUBE_KODU", Name = "IX_TBLSEPET_SUBE_KODU")]
public partial class TBLSEPET
{
    [Key]
    public int ID { get; set; }

    public string CARI_KODU { get; set; } = null!;

    public string TESLIM_CARI_KODU { get; set; } = null!;

    public string? ACIKLAMA { get; set; }

    public bool KDV_DAHIL { get; set; }

    public double ARA_TOPLAM { get; set; }

    public double KDV_TUTAR { get; set; }

    public double GENEL_TOPLAM { get; set; }

    public int DURUM { get; set; }

    public string? ISLEM_YAPAN { get; set; }

    public DateTime? ISLEM_TARIHI { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string? MUSTERI_ID { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSEPETs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;

    [InverseProperty("SEPET")]
    public virtual ICollection<TBLSEPETKALEM> TBLSEPETKALEMs { get; set; } = new List<TBLSEPETKALEM>();
}
