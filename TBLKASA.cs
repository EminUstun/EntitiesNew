using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLKASA")]
[Index("SUBE_KODU", Name = "IX_TBLKASA_SUBE_KODU")]
public partial class TBLKASA
{
    [Key]
    public int ID { get; set; }

    public string KASA_KODU { get; set; } = null!;

    public string? KASA_ADI { get; set; }

    public int SUBE_KODU { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CRATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public DateTime SON_DEVIR_TARIH { get; set; }

    public double SON_DEVIR_TUTAR { get; set; }

    public int DOVIZTIP_ID { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLKASAs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
