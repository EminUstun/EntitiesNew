using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLMONTAJBAGLANTI")]
[Index("SUBE_KODU", Name = "IX_TBLMONTAJBAGLANTI_SUBE_KODU")]
public partial class TBLMONTAJBAGLANTI
{
    [Key]
    public int ID { get; set; }

    public int MONTAJ_ID { get; set; }

    public string HAR_TIP { get; set; } = null!;

    public int HAR_ID { get; set; }

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    public int SUBE_KODU { get; set; }

    [ForeignKey("SUBE_KODU")]
    [InverseProperty("TBLMONTAJBAGLANTIs")]
    public virtual TBLSUBE SUBE_KODUNavigation { get; set; } = null!;
}
