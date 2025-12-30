using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLDASHBOARD")]
[Index("SUBE_KODU", Name = "IX_TBLDASHBOARD_SUBE_KODU")]
public partial class TBLDASHBOARD
{
    [Key]
    public int ID { get; set; }

    public string? Caption { get; set; }

    public byte[]? Dashboard { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLDASHBOARDs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
