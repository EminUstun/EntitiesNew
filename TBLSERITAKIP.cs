using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSERITAKIP")]
public partial class TBLSERITAKIP
{
    [Key]
    public int ID { get; set; }

    public string STOK_KODU { get; set; } = null!;

    public string SERI_NO { get; set; } = null!;

    public string GC_KOD { get; set; } = null!;

    public DateTime TARIH { get; set; }

    public string? ACIKLAMA { get; set; }

    public int YUK_ID { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int DEPO_KODU { get; set; }

    public int TIP { get; set; }
}
