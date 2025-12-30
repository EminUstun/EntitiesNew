using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLBANKABILGI")]
public partial class TBLBANKABILGI
{
    [Key]
    public int ID { get; set; }

    public string BANKA_KODU { get; set; } = null!;

    public string KULLANICI_ADI { get; set; } = null!;

    public string SIFRE { get; set; } = null!;

    public int KASA_KODU { get; set; }

    public string CLIENT_ID { get; set; } = null!;

    public string KEY_3D { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string? APPROVED_LINK { get; set; }

    public string DOGRULAMA_LINKI { get; set; } = null!;

    public string? NETHES_KODU { get; set; }

    public string? POSNET_ID { get; set; }

    public string? POS_TIPI { get; set; }

    public string? PROVISION_PASSWORD { get; set; }

    public int SUBE_KODU { get; set; }

    public string? TERMINAL_ID { get; set; }

    public string? TERMINAL_USER_ID { get; set; }

    public string? XML_LINKI { get; set; }
}
