using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBL_TRD_MONTAJ_MALZEME")]
public partial class TBL_TRD_MONTAJ_MALZEME
{
    [Key]
    public int ID { get; set; }

    public int? M_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? STOK_KODU { get; set; }

    public double? MIKTAR { get; set; }

    public double? FIYAT { get; set; }

    public double? TUTAR { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KAYITYAPAN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? KAYITTARIHI { get; set; }
}
