using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLILCELER")]
[Index("SEHIR_KODU", Name = "IX_TBLILCELER_SEHIR_KODU")]
[Index("SUBE_KODU", Name = "IX_TBLILCELER_SUBE_KODU")]
public partial class TBLILCELER
{
    [Key]
    public string ILCE_KODU { get; set; } = null!;

    public string ULKE_KODU { get; set; } = null!;

    public string SEHIR_KODU { get; set; } = null!;

    public string ILCE_ADI { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime? EDIT_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SEHIR_KODU")]
    [InverseProperty("TBLILCELERs")]
    public virtual TBLSEHIRLER SEHIR_KODUNavigation { get; set; } = null!;

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLILCELERs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
