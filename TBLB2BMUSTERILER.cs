using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLB2BMUSTERILER")]
[Index("SUBE_KODU", Name = "IX_TBLB2BMUSTERILER_SUBE_KODU")]
public partial class TBLB2BMUSTERILER
{
    [Key]
    public int ID { get; set; }

    public string? AD_SOYAD { get; set; }

    public string? ADRES { get; set; }

    public string? TELEFON { get; set; }

    public string? MAIL { get; set; }

    public string? ILCE { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLB2BMUSTERILERs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
