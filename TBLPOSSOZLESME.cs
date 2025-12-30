using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLPOSSOZLESME")]
[Index("SUBE_KODU", Name = "IX_TBLPOSSOZLESME_SUBE_KODU")]
public partial class TBLPOSSOZLESME
{
    [Key]
    public int ID { get; set; }

    public string? SOZLESME_KODU { get; set; }

    public string? HESAP_KODU { get; set; }

    public string? KASA_KODU { get; set; }

    public int TAKSIT { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLPOSSOZLESMEs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
