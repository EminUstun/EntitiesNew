using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLFIYATGRUP")]
[Index("SUBE_KODU", "FIYAT_GRUBU", Name = "IX_TBLFIYATGRUP_SUBE_KODU_FIYAT_GRUBU", IsUnique = true)]
public partial class TBLFIYATGRUP
{
    [Key]
    public string FIYAT_GRUBU { get; set; } = null!;

    public int SUBE_KODU { get; set; }

    public string ACIKLAMA { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public bool ISK_UYGULANSIN { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLFIYATGRUPs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
