using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLAYRILMISURUN")]
[Index("SUBE_KODU", Name = "IX_TBLAYRILMISURUN_SUBE_KODU")]
public partial class TBLAYRILMISURUN
{
    [Key]
    public int ID { get; set; }

    public int STOKHAR_ID { get; set; }

    public int MIKTAR { get; set; }

    public int TESLIM_EDILEN { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int CIKIS_DEPO { get; set; }

    public int GIRIS_DEPO { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLAYRILMISURUNs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
