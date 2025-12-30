using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSTOKTMP")]
[Index("SUBE_KODU", Name = "IX_TBLSTOKTMP_SUBE_KODU")]
public partial class TBLSTOKTMP
{
    [Key]
    public int ID { get; set; }

    public string? STOK_KODU { get; set; }

    public string? STOK_ADI { get; set; }

    public string? GRUP_KODU { get; set; }

    public string? KOD1 { get; set; }

    public string? KOD2 { get; set; }

    public string? KOD4 { get; set; }

    public string? KOD5 { get; set; }

    public string? OLCUBR1 { get; set; }

    public string? OLCUBR2 { get; set; }

    public double? KUTUSAYISI { get; set; }

    public double? KUTUDAKİADET { get; set; }

    public double? KDVORANI { get; set; }

    public double? ALISFIYATI { get; set; }

    public string? BARKOD1 { get; set; }

    public string? KULL1S { get; set; }

    public string? KULL2S { get; set; }

    public string? BSYGORSUN { get; set; }

    public double? GORUNENSTOK { get; set; }

    public double? ISKONTO { get; set; }

    public double? KONTEYNERADEDI { get; set; }

    public double? NAVLUN { get; set; }

    public double? USD { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSTOKTMPs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
