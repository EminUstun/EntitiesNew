using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLFATURA")]
public partial class TBLFATURA
{
    public int SUBE_KODU { get; set; }

    [StringLength(450)]
    public string TIP { get; set; } = null!;

    [StringLength(450)]
    public string FATNO { get; set; } = null!;

    [StringLength(450)]
    public string CARI_KODU { get; set; } = null!;

    public string TESLIM_CARI_KODU { get; set; } = null!;

    public DateTime? TARIH { get; set; }

    public DateTime? TESTARIH { get; set; }

    public DateTime? ODEME_TARIHI { get; set; }

    public int? ODEME_GUNU { get; set; }

    public bool KDV_DAHIL { get; set; }

    public double? ISK1_O { get; set; }

    public double? ISK2_O { get; set; }

    public double? ISK3_O { get; set; }

    public double? ISK1_T { get; set; }

    public double? ISK2_T { get; set; }

    public double? ISK3_T { get; set; }

    public double? ARA_TOPLAM { get; set; }

    public double? ISKONTO_TOPLAM { get; set; }

    public double? NET_TOPLAM { get; set; }

    public double? KDV_TOPLAM { get; set; }

    public double? GENEL_TOPLAM { get; set; }

    public string? EKACK1 { get; set; }

    public string? EKACK2 { get; set; }

    public string? EKACK3 { get; set; }

    public string? EKACK4 { get; set; }

    public string? EKACK5 { get; set; }

    public string? EKACK6 { get; set; }

    public string? EKACK7 { get; set; }

    public string? EKACK8 { get; set; }

    public string? EKACK9 { get; set; }

    public string? EKACK10 { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string? PLA_KODU { get; set; }

    public string? ACIKLAMA { get; set; }

    public string? ODEME_TIPI { get; set; }

    public double? TAHSILAT { get; set; }

    public int? TAKSIT_SAYISI { get; set; }

    public int? CIK_DEPO { get; set; }

    public int? GIR_DEPO { get; set; }

    public int DOVIZTIP_ID { get; set; }

    public double? DOVIZ_KUR { get; set; }

    public double? DOVIZ_TUTAR { get; set; }

    [Key]
    public int ID { get; set; }

    public string? MUSTERI_ID { get; set; }

    public bool IADE { get; set; }

    public string? YUKBELGENO { get; set; }

    public bool YUKEMRI { get; set; }

    public int YUK_DURUM { get; set; }

    public string? TESLIM_ADRES { get; set; }

    public bool IPTAL { get; set; }

    public bool ONAY { get; set; }

    public string? ONAY_YAPAN { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLFATURAs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
