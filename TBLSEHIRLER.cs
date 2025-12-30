using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSEHIRLER")]
[Index("ULKE_KODU", Name = "IX_TBLSEHIRLER_ULKE_KODU")]
public partial class TBLSEHIRLER
{
    [Key]
    public string SEHIR_KODU { get; set; } = null!;

    public string ULKE_KODU { get; set; } = null!;

    public string SEHIR_ADI { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime? EDIT_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    [InverseProperty("SEHIR_KODUNavigation")]
    public virtual ICollection<TBLILCELER> TBLILCELERs { get; set; } = new List<TBLILCELER>();

    [ForeignKey("ULKE_KODU")]
    [InverseProperty("TBLSEHIRLERs")]
    public virtual TBLULKELER ULKE_KODUNavigation { get; set; } = null!;
}
