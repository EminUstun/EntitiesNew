using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Keyless]
[Table("TBL_EVSB2B_TAHSILAT")]
[Index("ID", Name = "IX_TBL_EVSB2B_TAHSILAT", IsUnique = true)]
[Index("NETSISBELGENO", Name = "IX_TBL_EVSB2B_TAHSILAT_1")]
[Index("CARIKODU", Name = "IX_TBL_EVSB2B_TAHSILAT_2")]
[Index("KAYITYAPAN", Name = "IX_TBL_EVSB2B_TAHSILAT_3")]
[Index("CARIKODU", "BANKABELGENO", "KAYITYAPAN", Name = "IX_TBL_EVSB2B_TAHSILAT_4")]
[Index("BANKABELGENO", Name = "IX_TBL_EVSB2B_TAHSILAT_5")]
public partial class TBL_EVSB2B_TAHSILAT
{
    public int ID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string BANKABELGENO { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string? NETSISBELGENO { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? CARIKODU { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? CARIADI { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? BANKAKODU { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? BANKANETSISKODU { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? BANKAADI { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? KARTSAHIBI { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? KARTNUMARASI { get; set; }

    public double? TUTAR { get; set; }

    public int? TAKSIT { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? EMAIL { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? TELEFON { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TAKSITKODU { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TARIH { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? TARAYICI { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? IPADRES { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? LOKASYON { get; set; }

    public int? SUBEKODU { get; set; }

    public int? PLASIYERKODU { get; set; }

    public bool? ONAY { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? ONAYKODU { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? HATAKODU { get; set; }

    [Unicode(false)]
    public string? HATAACIKLAMASI { get; set; }

    public int? DEPARTMAN { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? USTCARIKODU { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? KAYITYAPAN { get; set; }

    public int? DURUM { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? AKTARIMHATA { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? ALTUNVAN { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? ACIKLAMA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MAKBUZNO { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ODEME_ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? HESABA_GECTI { get; set; }
}
