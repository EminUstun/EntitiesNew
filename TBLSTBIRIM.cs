using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSTBIRIM")]
[Index("SUBE_KODU", Name = "IX_TBLSTBIRIM_SUBE_KODU")]
public partial class TBLSTBIRIM
{
    public int SUBE_KODU { get; set; }

    [Key]
    public string OLCU_BIRIMI { get; set; } = null!;

    public string? ACIKLAMA { get; set; }

    public DateTime CREATE_TIME { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime? EDIT_TIME { get; set; }

    public string? EDIT_USER { get; set; }
}
