using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLKAMPANYA")]
[Index("SUBE_KODU", Name = "IX_TBLKAMPANYA_SUBE_KODU")]
public partial class TBLKAMPANYA
{
    [Key]
    public int ID { get; set; }

    public string KAMPANYA_ADI { get; set; } = null!;

    public DateTime BASLANGIC_TARIH { get; set; }

    public DateTime BITIS_TARIH { get; set; }

    public int KAMPANYA_TIPI { get; set; }

    public bool AKTIF { get; set; }

    public bool TASLAK { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLKAMPANYAs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
