using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLTEMPDATA")]
[Index("SUBE_KODU", Name = "IX_TBLTEMPDATA_SUBE_KODU")]
[Index("TEMP_ID", "USERNAME", Name = "IX_TBLTEMPDATA_TEMP_ID_USERNAME")]
public partial class TBLTEMPDATum
{
    [Key]
    public int ID { get; set; }

    public string TEMP_ID { get; set; } = null!;

    public string TEMP_CONTENT { get; set; } = null!;

    public string USERNAME { get; set; } = null!;

    public DateTime TEMP_DATE { get; set; }

    public string? TEMP_ID2 { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLTEMPDATa")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
