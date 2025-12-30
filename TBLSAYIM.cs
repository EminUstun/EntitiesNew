using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[PrimaryKey("SUBE_KODU", "STOK_KODU")]
[Table("TBLSAYIM")]
public partial class TBLSAYIM
{
    [Key]
    public int SUBE_KODU { get; set; }

    [Key]
    public string STOK_KODU { get; set; } = null!;

    public double MIKTAR { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSAYIMs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
