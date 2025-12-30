using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLPOSTAKSIT")]
public partial class TBLPOSTAKSIT
{
    [Key]
    public int ID { get; set; }

    public string BANKA_KODU { get; set; } = null!;

    public int ISYERI_TAKSIT { get; set; }

    public int BANKA_TAKSIT { get; set; }

    public double MIN_TUTAR { get; set; }

    public double MAX_TUTAR { get; set; }

    public string? ACIKLAMA { get; set; }

    public string TAKSIT { get; set; } = null!;

    public bool AKTIF { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }
}
