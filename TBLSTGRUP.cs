using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSTGRUP")]
[Index("SUBE_KODU", Name = "IX_TBLSTGRUP_SUBE_KODU")]
public partial class TBLSTGRUP
{
    [StringLength(400)]
    public string GRUP_KODU { get; set; } = null!;

    public string GRUP_TIPI { get; set; } = null!;

    public string? GRUP_ACIKLAMA { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public string? EDIT_USER { get; set; }

    public DateTime CREATE_TIME { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public bool B2B_SIPARIS { get; set; }

    [Key]
    public int ID { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSTGRUPs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
