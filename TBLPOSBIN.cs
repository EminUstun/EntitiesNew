using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLPOSBIN")]
public partial class TBLPOSBIN
{
    [Key]
    public int ID { get; set; }

    public string BANKA_KODU { get; set; } = null!;

    public int BIN_NO { get; set; }

    public string TIP_1 { get; set; } = null!;

    public string TIP_2 { get; set; } = null!;

    public bool TAKSIT { get; set; }

    public string TAKSIT_BANKA_KODU { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string? TIP_3 { get; set; }
}
