using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLTAKSITLIHESAP")]
[Index("HESAP_KODU", Name = "IX_TBLTAKSITLIHESAP_HESAP_KODU")]
[Index("SUBE_KODU", Name = "IX_TBLTAKSITLIHESAP_SUBE_KODU")]
public partial class TBLTAKSITLIHESAP
{
    [Key]
    public int ID { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TAKSIT_TUTARI { get; set; }

    public string TAKSITNO { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ODENEN_TUTAR { get; set; }

    public DateTime TAKSIT_TARIHI { get; set; }

    public string HESAP_KODU { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("HESAP_KODU")]
    [InverseProperty("TBLTAKSITLIHESAPs")]
    public virtual TBLBANKAHESAP HESAP_KODUNavigation { get; set; } = null!;

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLTAKSITLIHESAPs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
