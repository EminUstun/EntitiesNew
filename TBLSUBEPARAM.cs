using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSUBEPARAM")]
[Index("SUBE_KODU", Name = "IX_TBLSUBEPARAM_SUBE_KODU")]
public partial class TBLSUBEPARAM
{
    public int SUBE_KODU { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    [Key]
    public string FATURA_TIPI_DEFAULT { get; set; } = null!;

    public string? CARI_KULL1N_CPT { get; set; }

    public string? CARI_KULL2N_CPT { get; set; }

    public string? CARI_KULL3N_CPT { get; set; }

    public string? CARI_KULL4N_CPT { get; set; }

    public string? CARI_KULL5N_CPT { get; set; }

    public string? CARI_KULL6N_CPT { get; set; }

    public string? CARI_KULL7N_CPT { get; set; }

    public string? CARI_KULL8N_CPT { get; set; }

    public string? CARI_KULL1S_CPT { get; set; }

    public string? CARI_KULL2S_CPT { get; set; }

    public string? CARI_KULL3S_CPT { get; set; }

    public string? CARI_KULL4S_CPT { get; set; }

    public string? CARI_KULL5S_CPT { get; set; }

    public string? CARI_KULL6S_CPT { get; set; }

    public string? CARI_KULL7S_CPT { get; set; }

    public string? CARI_KULL8S_CPT { get; set; }

    public string? STOK_KULL1N_CPT { get; set; }

    public string? STOK_KULL2N_CPT { get; set; }

    public string? STOK_KULL3N_CPT { get; set; }

    public string? STOK_KULL4N_CPT { get; set; }

    public string? STOK_KULL5N_CPT { get; set; }

    public string? STOK_KULL6N_CPT { get; set; }

    public string? STOK_KULL7N_CPT { get; set; }

    public string? STOK_KULL8N_CPT { get; set; }

    public string? STOK_KULL1S_CPT { get; set; }

    public string? STOK_KULL2S_CPT { get; set; }

    public string? STOK_KULL3S_CPT { get; set; }

    public string? STOK_KULL4S_CPT { get; set; }

    public string? STOK_KULL5S_CPT { get; set; }

    public string? STOK_KULL6S_CPT { get; set; }

    public string? STOK_KULL7S_CPT { get; set; }

    public string? STOK_KULL8S_CPT { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLSUBEPARAMs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
