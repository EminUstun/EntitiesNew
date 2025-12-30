using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBL_TRD_KAMP")]
public partial class TBL_TRD_KAMP
{
    [Key]
    public int ID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? KAMPKODU { get; set; }

    [Unicode(false)]
    public string? KAMPADI { get; set; }

    [Unicode(false)]
    public string? KAMPACIKLAMA { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? GORSEL { get; set; }

    public byte[]? GORSEL2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TIP { get; set; }

    public DateOnly? BASTAR { get; set; }

    public DateOnly? BITTAR { get; set; }

    public bool? AKTIF { get; set; }

    public bool? TASLAK { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KAYITYAPAN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? KAYITTARIHI { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DUZELTMEYAPAN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DUZELTMETARIHI { get; set; }
}
