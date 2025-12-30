using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLEXCEL")]
[Index("SUBE_KODU", Name = "IX_TBLEXCEL_SUBE_KODU")]
public partial class TBLEXCEL
{
    [Key]
    public int ID { get; set; }

    public string NAME { get; set; } = null!;

    public byte[] DATA { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLEXCELs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
