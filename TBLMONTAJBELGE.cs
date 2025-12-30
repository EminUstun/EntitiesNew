using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLMONTAJBELGE")]
[Index("SUBE_KODU", Name = "IX_TBLMONTAJBELGE_SUBE_KODU")]
public partial class TBLMONTAJBELGE
{
    [Key]
    public int ID { get; set; }

    public int MONTAJ_ID { get; set; }

    public byte[] BELGE { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLMONTAJBELGEs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
