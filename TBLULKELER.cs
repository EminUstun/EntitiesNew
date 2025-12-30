using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLULKELER")]
[Index("SUBE_KODU", Name = "IX_TBLULKELER_SUBE_KODU")]
public partial class TBLULKELER
{
    [Key]
    public string ULKE_KODU { get; set; } = null!;

    public string ULKE_ADI { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLULKELERs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;

    [InverseProperty("ULKE_KODUNavigation")]
    public virtual ICollection<TBLSEHIRLER> TBLSEHIRLERs { get; set; } = new List<TBLSEHIRLER>();
}
