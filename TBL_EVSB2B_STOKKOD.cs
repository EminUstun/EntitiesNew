using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBL_EVSB2B_STOKKOD")]
public partial class TBL_EVSB2B_STOKKOD
{
    [Key]
    public int ID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? GRUPKODU { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? KOD1 { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? KOD1ADI { get; set; }

    public bool? YAPKOD { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? KAMPANYA { get; set; }

    [StringLength(250)]
    public string? ACIKLAMA { get; set; }

    public bool? AKTIF { get; set; }

    [StringLength(250)]
    public string? KAMP_KODU { get; set; }

    public byte[]? IMAGE { get; set; }

    [StringLength(5)]
    public string? TEST { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BASLANGIC_TARIHI { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BITIS_TARIHI { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? KAYIT_TARIHI { get; set; }
}
