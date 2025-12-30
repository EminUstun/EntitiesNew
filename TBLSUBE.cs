using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCopy.Entities;

[Table("TBLSUBE")]
public partial class TBLSUBE
{
    [Key]
    public int SUBE_KODU { get; set; }

    public string SUBE_ADI { get; set; } = null!;

    public string CREATE_USER { get; set; } = null!;

    public DateTime CREATE_TIME { get; set; }

    public string? EDIT_USER { get; set; }

    public DateTime? EDIT_TIME { get; set; }

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<AspNetUser> AspNetUsers { get; set; } = new List<AspNetUser>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLARIZA> TBLARIZAs { get; set; } = new List<TBLARIZA>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLAYRILMISURUN> TBLAYRILMISURUNs { get; set; } = new List<TBLAYRILMISURUN>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLB2BMUSTERILER> TBLB2BMUSTERILERs { get; set; } = new List<TBLB2BMUSTERILER>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLBANKAHESAP> TBLBANKAHESAPs { get; set; } = new List<TBLBANKAHESAP>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLBCEK> TBLBCEKs { get; set; } = new List<TBLBCEK>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLBNKHESHAR> TBLBNKHESHARs { get; set; } = new List<TBLBNKHESHAR>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLBSEN> TBLBSENs { get; set; } = new List<TBLBSEN>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLCAGRUP> TBLCAGRUPs { get; set; } = new List<TBLCAGRUP>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLCARIHAR> TBLCARIHARs { get; set; } = new List<TBLCARIHAR>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLCARI> TBLCARIs { get; set; } = new List<TBLCARI>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLCEKLOG> TBLCEKLOGs { get; set; } = new List<TBLCEKLOG>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLDASHBOARD> TBLDASHBOARDs { get; set; } = new List<TBLDASHBOARD>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLDIZAYN> TBLDIZAYNs { get; set; } = new List<TBLDIZAYN>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLDOVIZTIP> TBLDOVIZTIPs { get; set; } = new List<TBLDOVIZTIP>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLERPLOG> TBLERPLOGs { get; set; } = new List<TBLERPLOG>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLEXCEL> TBLEXCELs { get; set; } = new List<TBLEXCEL>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLFATURA> TBLFATURAs { get; set; } = new List<TBLFATURA>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLFIYATGRUP> TBLFIYATGRUPs { get; set; } = new List<TBLFIYATGRUP>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLILCELER> TBLILCELERs { get; set; } = new List<TBLILCELER>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLKAMPANYAISKONTO> TBLKAMPANYAISKONTOs { get; set; } = new List<TBLKAMPANYAISKONTO>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLKAMPANYAPAKET> TBLKAMPANYAPAKETs { get; set; } = new List<TBLKAMPANYAPAKET>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLKAMPANYA> TBLKAMPANYAs { get; set; } = new List<TBLKAMPANYA>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLKASAHAR> TBLKASAHARs { get; set; } = new List<TBLKASAHAR>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLKASA> TBLKASAs { get; set; } = new List<TBLKASA>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLMCEK> TBLMCEKs { get; set; } = new List<TBLMCEK>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLMENU> TBLMENUs { get; set; } = new List<TBLMENU>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLMODULMENU> TBLMODULMENUs { get; set; } = new List<TBLMODULMENU>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLMONTAJBAGLANTI> TBLMONTAJBAGLANTIs { get; set; } = new List<TBLMONTAJBAGLANTI>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLMONTAJBELGE> TBLMONTAJBELGEs { get; set; } = new List<TBLMONTAJBELGE>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLMONTAJDETAY> TBLMONTAJDETAYs { get; set; } = new List<TBLMONTAJDETAY>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLMONTAJLOG> TBLMONTAJLOGs { get; set; } = new List<TBLMONTAJLOG>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLMONTAJ> TBLMONTAJs { get; set; } = new List<TBLMONTAJ>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLPLASIYER> TBLPLASIYERs { get; set; } = new List<TBLPLASIYER>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLPOSSOZLESME> TBLPOSSOZLESMEs { get; set; } = new List<TBLPOSSOZLESME>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSAYIMDEPO> TBLSAYIMDEPOs { get; set; } = new List<TBLSAYIMDEPO>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSAYIM> TBLSAYIMs { get; set; } = new List<TBLSAYIM>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSEPETKALEM> TBLSEPETKALEMs { get; set; } = new List<TBLSEPETKALEM>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSEPET> TBLSEPETs { get; set; } = new List<TBLSEPET>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSERVISARIZALOG> TBLSERVISARIZALOGs { get; set; } = new List<TBLSERVISARIZALOG>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSERVISARIZAMALZEME> TBLSERVISARIZAMALZEMEs { get; set; } = new List<TBLSERVISARIZAMALZEME>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSERVISARIZA> TBLSERVISARIZAs { get; set; } = new List<TBLSERVISARIZA>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSIRKETPARAM> TBLSIRKETPARAMs { get; set; } = new List<TBLSIRKETPARAM>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSTGRUP> TBLSTGRUPs { get; set; } = new List<TBLSTGRUP>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSTOKDP> TBLSTOKDPs { get; set; } = new List<TBLSTOKDP>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSTOKFIYATTEMP> TBLSTOKFIYATTEMPs { get; set; } = new List<TBLSTOKFIYATTEMP>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSTOKFIYAT> TBLSTOKFIYATs { get; set; } = new List<TBLSTOKFIYAT>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSTOKHAR> TBLSTOKHARs { get; set; } = new List<TBLSTOKHAR>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSTOKPH> TBLSTOKPHs { get; set; } = new List<TBLSTOKPH>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSTOKTMP> TBLSTOKTMPs { get; set; } = new List<TBLSTOKTMP>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSTOK> TBLSTOKs { get; set; } = new List<TBLSTOK>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLSUBEPARAM> TBLSUBEPARAMs { get; set; } = new List<TBLSUBEPARAM>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLTAKSITLIHESAP> TBLTAKSITLIHESAPs { get; set; } = new List<TBLTAKSITLIHESAP>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLTAKSITLISOZLESME> TBLTAKSITLISOZLESMEs { get; set; } = new List<TBLTAKSITLISOZLESME>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLTEMPDATum> TBLTEMPDATa { get; set; } = new List<TBLTEMPDATum>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBLULKELER> TBLULKELERs { get; set; } = new List<TBLULKELER>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TBL_EVSB2B_KULLANICILAR> TBL_EVSB2B_KULLANICILARs { get; set; } = new List<TBL_EVSB2B_KULLANICILAR>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TMPALACAK> TMPALACAKs { get; set; } = new List<TMPALACAK>();

    [InverseProperty("SUBE_KODUNavigation")]
    public virtual ICollection<TMPBORC> TMPBORCs { get; set; } = new List<TMPBORC>();
}
