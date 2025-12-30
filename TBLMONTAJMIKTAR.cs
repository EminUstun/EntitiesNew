using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLMONTAJMIKTAR")]
public partial class TBLMONTAJMIKTAR
{
    [Key]
    public int ID { get; set; }

    public int MONTAJ_ID { get; set; }

    public double MIKTAR { get; set; }

    public string? ATANAN { get; set; }

    public string? GERCEKLESTIREN { get; set; }

    public DateTime? PLAN_TARIH { get; set; }

    public DateTime? GERCEKLESME_TARIH { get; set; }

    public DateTime? TESLIM_TARIH { get; set; }

    public DateTime? ATOLYE_GIRIS_TARIHI { get; set; }

    public int DURUM { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public bool YAZDIR { get; set; }
}
