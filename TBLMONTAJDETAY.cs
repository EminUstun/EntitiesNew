using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLMONTAJDETAY")]
[Index("SUBE_KODU", Name = "IX_TBLMONTAJDETAY_SUBE_KODU")]
public partial class TBLMONTAJDETAY
{
    [Key]
    public int ID { get; set; }

    public int MONTAJ_ID { get; set; }

    public string ISIM_SOYISIM { get; set; } = null!;

    public string ADRES { get; set; } = null!;

    public string BOLGE { get; set; } = null!;

    public string TELEFON { get; set; } = null!;

    public string? EMAIL { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLMONTAJDETAYs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
