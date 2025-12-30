using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[PrimaryKey("SUBE_KODU", "PARAM_NAME")]
[Table("TBLSIRKETPARAM")]
public partial class TBLSIRKETPARAM
{
    [Key]
    public int SUBE_KODU { get; set; }

    [Key]
    public string PARAM_NAME { get; set; } = null!;

    public string? PARAM_VALUE { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSIRKETPARAMs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
