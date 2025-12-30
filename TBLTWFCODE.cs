using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLTWFCODE")]
[Index("USERID", Name = "IX_TBLTWFCODE_USERID")]
public partial class TBLTWFCODE
{
    [Key]
    public int ID { get; set; }

    public string USERID { get; set; } = null!;

    public string CODE { get; set; } = null!;

    public DateTime EXPDATE { get; set; }

    public bool ISACTIVE { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public string KEY { get; set; } = null!;

    [ForeignKey("USERID")]
    [InverseProperty("TBLTWFCODEs")]
    public virtual AspNetUser USER { get; set; } = null!;
}
