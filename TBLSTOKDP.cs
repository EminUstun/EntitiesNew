using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSTOKDP")]
[Index("SUBE_KODU", "DEPO_KODU", Name = "IX_TBLSTOKDP_SUBE_KODU_DEPO_KODU", IsUnique = true)]
public partial class TBLSTOKDP
{
    [Key]
    public int DEPO_KODU { get; set; }

    public int SUBE_KODU { get; set; }

    public string? DEPO_ADI { get; set; }

    public bool EKSI_BAKIYE_KONTROL { get; set; }

    public bool AKTIF { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSTOKDPs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
