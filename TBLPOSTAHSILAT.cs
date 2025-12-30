using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLPOSTAHSILAT")]
public partial class TBLPOSTAHSILAT
{
    [Key]
    public int ID { get; set; }

    public string BANKABELGENO { get; set; } = null!;

    public string BELGENO { get; set; } = null!;

    public string CARI_KODU { get; set; } = null!;

    public string BANKA_KODU { get; set; } = null!;

    public int TAKSIT_KODU { get; set; }

    public double TUTAR { get; set; }

    public int TAKSIT { get; set; }

    public DateTime TARIH { get; set; }

    public bool ONAY { get; set; }

    public string? ONAY_KODU { get; set; }

    public string? HATA_KODU { get; set; }

    public string? HATA_ACIKLAMA { get; set; }

    public bool DOGRULAMA { get; set; }

    public string KART_SAHIBI { get; set; } = null!;

    public string KART_NUMARASI { get; set; } = null!;

    public string? EMAIL { get; set; }

    public string TELEFON { get; set; } = null!;

    public string? MAKBUZNO { get; set; }

    public bool DURUM { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string? ORDER_ID { get; set; }
}
