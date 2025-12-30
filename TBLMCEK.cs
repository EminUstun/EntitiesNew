using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLMCEK")]
[Index("SUBE_KODU", Name = "IX_TBLMCEK_SUBE_KODU")]
public partial class TBLMCEK
{
    [Key]
    public int SC_NO { get; set; }

    public int SUBE_KODU { get; set; }

    public string? ALB_NO { get; set; }

    public string? VRB_NO { get; set; }

    public string? CEK_SERI { get; set; }

    public string? VEREN_KODU { get; set; }

    public string? VERILEN_KODU { get; set; }

    public string? ASIL_BORCLU { get; set; }

    public DateTime? GIRIS_TARIHI { get; set; }

    public DateTime? VADE_TARIHI { get; set; }

    public double TUTAR { get; set; }

    public string? YERI { get; set; }

    public string? CEK_SUBE { get; set; }

    public string? CEK_IL { get; set; }

    public string? SC_YERI { get; set; }

    public string? SON_DUR { get; set; }

    public string? RAPOR_KODU { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string? AC { get; set; }

    public string? A_TCKIMLIKNO { get; set; }

    public string? A_VERGINO { get; set; }

    public string? HESAP_NO { get; set; }

    public string? PLA_KODU { get; set; }

    public DateTime? CIKIS_TARIHI { get; set; }

    public string? BAG_NO { get; set; }

    public int DOVIZTIP_ID { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLMCEKs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
