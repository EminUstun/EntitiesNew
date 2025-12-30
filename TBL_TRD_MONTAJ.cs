using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBL_TRD_MONTAJ")]
[Index("BAYI_CARI_KODU", "STOK_KODU", Name = "IX_TBL_TRD_MONTAJ")]
[Index("SIPARISNO", "STOK_KODU", Name = "IX_TBL_TRD_MONTAJ_1")]
[Index("SIPARISNO", "BAYI_CARI_KODU", "STOK_KODU", Name = "IX_TBL_TRD_MONTAJ_2")]
public partial class TBL_TRD_MONTAJ
{
    [Key]
    public int ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ISLEM_TIPI { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BAYI_CARI_KODU { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? STOK_KODU { get; set; }

    public int? MIKTAR { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? AD_SOYAD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TELEFON { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ILCE { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ADRES { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? BAYI_ACIKLAMA { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SERVIS_ACIKLAMA { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PLANLANAN_TARIH { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GERCEKLESME_TARIH { get; set; }

    public int? DURUM { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KAYITYAPAN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? KAYITTARIHI { get; set; }

    public bool? SIPARISMI { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SIPARISNO { get; set; }

    public int? SIRA { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PERIYODIK_BAKIM { get; set; }

    public int? PERIYODIK_GUN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TEKNISYEN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BAYI_DEPO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GARANTI { get; set; }

    public DateOnly? TESLIM_TARIHI { get; set; }

    public DateOnly? ATOLYE_GIRIS_TARIHI { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PLANLAMA_YAPAN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TEKNISYEN_ATAYAN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TEK_ATAMA_TARIH { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PLAN_YAPAN_TARIH { get; set; }
}
