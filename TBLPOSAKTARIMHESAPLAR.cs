using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLPOSAKTARIMHESAPLAR")]
public partial class TBLPOSAKTARIMHESAPLAR
{
    [Key]
    public int ID { get; set; }

    public string? BANKA_KODU { get; set; }

    public string? HESAP_KODU { get; set; }
}
