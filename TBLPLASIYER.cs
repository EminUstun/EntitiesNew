using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLPLASIYER")]
[Index("SUBE_KODU", "PLASIYER_KODU", Name = "IX_TBLPLASIYER_SUBE_KODU_PLASIYER_KODU", IsUnique = true)]
public partial class TBLPLASIYER
{
    [Key]
    public string PLASIYER_KODU { get; set; } = null!;

    public int SUBE_KODU { get; set; }

    public string ACIKLAMA { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLPLASIYERs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
