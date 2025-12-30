using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLKAMPANYAHEDIYE")]
public partial class TBLKAMPANYAHEDIYE
{
    [Key]
    public int ID { get; set; }

    public int KAMPANYA_ID { get; set; }

    public string ANA_STOK { get; set; } = null!;

    public string HEDIYE_STOK { get; set; } = null!;

    public double ANA_MIKTAR { get; set; }

    public double YAN_MIKTAR { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }
}
