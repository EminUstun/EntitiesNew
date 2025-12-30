using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBL_TRD_KAMP_COKLUHEDIYE_ANAURUN")]
public partial class TBL_TRD_KAMP_COKLUHEDIYE_ANAURUN
{
    [Key]
    public int ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KAMPKODU { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? KAMPADI { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? ANA_URUN { get; set; }

    public int? MIKTAR { get; set; }

    public double? FIYAT1 { get; set; }

    public double? FIYAT2 { get; set; }

    public double? FIYAT3 { get; set; }

    public double? FIYAT4 { get; set; }

    public double? FIYAT5 { get; set; }

    public double? FIYAT6 { get; set; }

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
