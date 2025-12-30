using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLMODULMENU")]
[Index("SUBE_KODU", Name = "IX_TBLMODULMENU_SUBE_KODU")]
public partial class TBLMODULMENU
{
    [Key]
    public int ID { get; set; }

    public int MODUL_SIRA { get; set; }

    public string? MODUL_KODU { get; set; }

    public string? MODUL_ADI { get; set; }

    public int MENU_SIRA { get; set; }

    public string? MENU_ADI { get; set; }

    public string? CONTROLLER { get; set; }

    public string? ACTION { get; set; }

    public string? URL_KEY { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string Role { get; set; } = null!;

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLMODULMENUs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
