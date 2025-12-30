using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLCAGRUP")]
[Index("GRUP_TIPI", "GRUP_KODU", Name = "IX_TBLCAGRUP_GRUP_TIPI_GRUP_KODU")]
[Index("SUBE_KODU", Name = "IX_TBLCAGRUP_SUBE_KODU")]
public partial class TBLCAGRUP
{
    [Key]
    public string GRUP_KODU { get; set; } = null!;

    public string GRUP_TIPI { get; set; } = null!;

    public string? GRUP_ACIKLAMA { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public string? EDIT_USER { get; set; }

    public DateTime CREATE_TIME { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLCAGRUPs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
