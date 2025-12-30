using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLBANKAHESAP")]
[Index("BANKA_KODU", Name = "IX_TBLBANKAHESAP_BANKA_KODU")]
[Index("DOVIZTIP_ID", Name = "IX_TBLBANKAHESAP_DOVIZTIP_ID")]
[Index("SUBE_KODU", Name = "IX_TBLBANKAHESAP_SUBE_KODU")]
public partial class TBLBANKAHESAP
{
    [Key]
    public string HESAP_KODU { get; set; } = null!;

    public int SUBE_KODU { get; set; }

    public string BANKA_KODU { get; set; } = null!;

    public string HESAP_ADI { get; set; } = null!;

    public string BANKA_HESAP_NO { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int HESAP_TIPI { get; set; }

    public int DOVIZTIP_ID { get; set; }

    public DateTime ILK_TAKSIT_TARIH { get; set; }

    public int? TAKSIT_SAYISI { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TAKSIT_TOPLAM_TUTAR { get; set; }

    [ForeignKey("BANKA_KODU")]
    [InverseProperty("TBLBANKAHESAPs")]
    public virtual TBLBANKA BANKA_KODUNavigation { get; set; } = null!;

    [ForeignKey("DOVIZTIP_ID")]
    [InverseProperty("TBLBANKAHESAPs")]
    public virtual TBLDOVIZTIP DOVIZTIP { get; set; } = null!;

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLBANKAHESAPs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;

    [InverseProperty("HESAP_KODUNavigation")]
    public virtual ICollection<TBLTAKSITLIHESAP> TBLTAKSITLIHESAPs { get; set; } = new List<TBLTAKSITLIHESAP>();
}
