using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLDIZAYN")]
[Index("SUBE_KODU", Name = "IX_TBLDIZAYN_SUBE_KODU")]
public partial class TBLDIZAYN
{
    [Key]
    public int ID { get; set; }

    public string? TIP { get; set; }

    public string DIZAYN_ADI { get; set; } = null!;

    public string? DIZAYN { get; set; }

    public byte[]? DATA { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLDIZAYNs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
