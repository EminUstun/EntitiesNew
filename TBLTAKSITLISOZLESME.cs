using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLTAKSITLISOZLESME")]
[Index("SUBE_KODU", Name = "IX_TBLTAKSITLISOZLESME_SUBE_KODU")]
public partial class TBLTAKSITLISOZLESME
{
    [Key]
    public int ID { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TAKSIT_TUTARI { get; set; }

    public string TAKSITNO { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ODENEN_TUTAR { get; set; }

    public DateTime TAKSIT_TARIHI { get; set; }

    public string FATNO { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PESINAT { get; set; }

    public string PESINAT_ODEME_TIPI { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string? CEK_NO { get; set; }

    public bool? MUSTERI_CEKI { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLTAKSITLISOZLESMEs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
