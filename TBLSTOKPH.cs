using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[PrimaryKey("STOK_KODU", "DEPO_KODU")]
[Table("TBLSTOKPH")]
[Index("STOK_KODU", "DEPO_KODU", Name = "IX_TBLSTOKPH_STOK_KODU_DEPO_KODU", IsUnique = true)]
[Index("SUBE_KODU", Name = "IX_TBLSTOKPH_SUBE_KODU")]
public partial class TBLSTOKPH
{
    [Key]
    public string STOK_KODU { get; set; } = null!;

    [Key]
    public int DEPO_KODU { get; set; }

    public double TOP_GIRIS { get; set; }

    public double TOP_CIKIS { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSTOKPHs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
