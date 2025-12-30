using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSAYIMDEPO")]
public partial class TBLSAYIMDEPO
{
    public int SUBE_KODU { get; set; }

    [StringLength(450)]
    public string STOK_KODU { get; set; } = null!;

    public int DEPO_KODU { get; set; }

    public double MIKTAR { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    [StringLength(450)]
    public string ACIKLAMA { get; set; } = null!;

    [Key]
    public int ID { get; set; }

    public DateTime? TARIH { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSAYIMDEPOs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
