using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLKASAHAR")]
[Index("SUBE_KODU", Name = "IX_TBLKASAHAR_SUBE_KODU")]
public partial class TBLKASAHAR
{
    [Key]
    public int ID { get; set; }

    public int SUBE_KODU { get; set; }

    public string KASA_KODU { get; set; } = null!;

    public DateTime TARIH { get; set; }

    public string? FISNO { get; set; }

    public string GC { get; set; } = null!;

    public string TIP { get; set; } = null!;

    public double TUTAR { get; set; }

    public string? ACIKLAMA { get; set; }

    public string? PLA_KODU { get; set; }

    public string BAG_NO { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string KOD { get; set; } = null!;

    public int DOVIZTIP_ID { get; set; }

    public double? DOVIZ_KUR { get; set; }

    public double? DOVIZ_TUTAR { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLKASAHARs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
