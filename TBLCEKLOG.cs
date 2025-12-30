using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLCEKLOG")]
[Index("SUBE_KODU", Name = "IX_TBLCEKLOG_SUBE_KODU")]
public partial class TBLCEKLOG
{
    [Key]
    public int ID { get; set; }

    public int SC_NO { get; set; }

    public string ACIKLAMA { get; set; } = null!;

    public string DURUM { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLCEKLOGs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
