using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLKAMPANYAPAKET")]
[Index("SUBE_KODU", Name = "IX_TBLKAMPANYAPAKET_SUBE_KODU")]
public partial class TBLKAMPANYAPAKET
{
    [Key]
    public int ID { get; set; }

    public int KAMPANYA_ID { get; set; }

    public string STOK_KODU { get; set; } = null!;

    public int MIKTAR { get; set; }

    public double URUN_FIYAT { get; set; }

    public double PAKET_FIYAT { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLKAMPANYAPAKETs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
