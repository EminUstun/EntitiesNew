using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSERI")]
public partial class TBLSERI
{
    [Key]
    public int ID { get; set; }

    public string STOK_KODU { get; set; } = null!;

    public string SERI_NO { get; set; } = null!;

    public string SON_DURUM { get; set; } = null!;

    public DateTime? SON_DURUM_TARIH { get; set; }

    public string? ACIKLAMA { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }
}
