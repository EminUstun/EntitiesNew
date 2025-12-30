using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLMENU")]
[Index("SUBE_KODU", Name = "IX_TBLMENU_SUBE_KODU")]
public partial class TBLMENU
{
    [Key]
    public int ID { get; set; }

    public int? PID { get; set; }

    public string MENU_ADI { get; set; } = null!;

    public string MENU_ICON { get; set; } = null!;

    public string CONTROLLER { get; set; } = null!;

    public string ACTION { get; set; } = null!;

    public string? URL_KEY { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLMENUs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
