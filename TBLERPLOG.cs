using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLERPLOG")]
[Index("SUBE_KODU", Name = "IX_TBLERPLOG_SUBE_KODU")]
public partial class TBLERPLOG
{
    [Key]
    public int ID { get; set; }

    public string? TABLE_NAME { get; set; }

    public string? ACTION { get; set; }

    public string? OLD_VALUE { get; set; }

    public string? NEW_VALUE { get; set; }

    public string? DELETE_VALUE { get; set; }

    public string? CREATE_USER { get; set; }

    public DateTime? CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLERPLOGs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
