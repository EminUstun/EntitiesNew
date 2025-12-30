using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLKAMPANYAISKONTO")]
[Index("SUBE_KODU", Name = "IX_TBLKAMPANYAISKONTO_SUBE_KODU")]
public partial class TBLKAMPANYAISKONTO
{
    [Key]
    public int ID { get; set; }

    public int KAMPANYA_ID { get; set; }

    public string STOK_KODU { get; set; } = null!;

    public double ISKONTO_FIYAT_1 { get; set; }

    public double ISKONTO_FIYAT_2 { get; set; }

    public double ISKONTO_FIYAT_3 { get; set; }

    public double ISKONTO_FIYAT_4 { get; set; }

    public double ISKONTO_FIYAT_5 { get; set; }

    public double ISKONTO_FIYAT_6 { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLKAMPANYAISKONTOs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
