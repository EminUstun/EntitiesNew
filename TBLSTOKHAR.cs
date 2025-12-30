using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSTOKHAR")]
public partial class TBLSTOKHAR
{
    [Key]
    public int ID { get; set; }

    public int SUBE_KODU { get; set; }

    [StringLength(450)]
    public string? FISNO { get; set; }

    [StringLength(450)]
    public string TIP { get; set; } = null!;

    [StringLength(450)]
    public string? CARI_KODU { get; set; }

    [StringLength(450)]
    public string? TESLIM_CARI_KODU { get; set; }

    public string? ACIKLAMA { get; set; }

    public string? ACIKLAMA2 { get; set; }

    public string? ACIKLAMA3 { get; set; }

    [StringLength(450)]
    public string STOK_KODU { get; set; } = null!;

    public string GC_KOD { get; set; } = null!;

    public double MIKTAR { get; set; }

    public double FIYAT { get; set; }

    public double? SAT_ISK1 { get; set; }

    public double? SAT_ISK2 { get; set; }

    public double? SAT_ISK3 { get; set; }

    public double? SAT_ISK4 { get; set; }

    public double? SAT_ISK5 { get; set; }

    public double? SAT_ISK6 { get; set; }

    public string? SAT_ACIK1 { get; set; }

    public string? SAT_ACIK2 { get; set; }

    public string? SAT_ACIK3 { get; set; }

    public string? SAT_ACIK4 { get; set; }

    public string? SAT_ACIK5 { get; set; }

    public string? BAG_NO { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string? PLA_KODU { get; set; }

    public int DEPO_KODU { get; set; }

    public double? NET_FIYAT { get; set; }

    public double KDV_ORAN { get; set; }

    public double TESLIM_EDILEN { get; set; }

    public DateTime TARIH { get; set; }

    public string? EKALAN { get; set; }

    public string? EKALAN1 { get; set; }

    public int? SIRA { get; set; }

    public string? SAT_ISK1_TIP { get; set; }

    public int DOVIZTIP_ID { get; set; }

    public double? DOVIZ_KUR { get; set; }

    public double? DOVIZ_TUTAR { get; set; }

    public string? MUSTERI_UST { get; set; }

    public bool IADE { get; set; }

    public string? URUN_SERI { get; set; }

    public string? TESLIMAT_EKIP { get; set; }

    public DateTime? TESLIM_CIK_TARIH { get; set; }

    public int TESLIM_DURUM { get; set; }

    public DateTime? TESLIM_TAM_TARIH { get; set; }

    public string? YUKBELGENO { get; set; }

    public bool YUKEMRI { get; set; }

    public double OKUTULAN { get; set; }

    public int YUK_DURUM { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSTOKHARs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
