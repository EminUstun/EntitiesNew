using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLPOSBANKA")]
public partial class TBLPOSBANKA
{
    [Key]
    public int ID { get; set; }

    public string BANKA_KODU { get; set; } = null!;

    public int SUBE_KODU { get; set; }

    public bool VARSAYILAN { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }
}
