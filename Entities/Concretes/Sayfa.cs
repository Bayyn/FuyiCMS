using System;
using Entities.Abstracts;

namespace Entities.Concretes;

public class Sayfa:ISayfa
{
    public int SayfaID { get; set; }
    public string? SayfaAktif { get; set; }
    public string? SayfaPicUrl { get; set; }
    public int SayfaSira { get; set; }
    public int SayfaFirmaID { get; set; }
    public int SayfaFotoCat { get; set; }
    public int SayfaFlashCat { get; set; }
    public string? SayfaPencere { get; set; }
    public string? SayfaTip { get; set; }
    public string? SayfaLink1 { get; set; }
    public string? SayfaLink2 { get; set; }
    public string? SayfaLink3 { get; set; }
    public string? SayfaLink4 { get; set; }

    public string? SayfaName1 { get; set; }
    public string? SayfaName2 { get; set; }
    public string? SayfaName3 { get; set; }
    public string? SayfaName4 { get; set; }

    public string? SayfaOzet1 { get; set; }
    public string? SayfaOzet2 { get; set; }
    public string? SayfaOzet3 { get; set; }
    public string? SayfaOzet4 { get; set; }

    public string? SayfaDetay1 { get; set; }
    public string? SayfaDetay2 { get; set; }
    public string? SayfaDetay3 { get; set; }
    public string? SayfaDetay4 { get; set; }

    public string? SayfaPermaLink1 { get; set; }
    public string? SayfaPermaLink2 { get; set; }
    public string? SayfaPermaLink3 { get; set; }
    public string? SayfaPermaLink4 { get; set; }

    public string? SayfaKeywords1 { get; set; }
    public string? SayfaKeywords2 { get; set; }
    public string? SayfaKeywords3 { get; set; }
    public string? SayfaKeywords4 { get; set; }

    public string? SayfaDescription1 { get; set; }
    public string? SayfaDescription2 { get; set; }
    public string? SayfaDescription3 { get; set; }
    public string? SayfaDescription4 { get; set; }

    public string? SayfaTitle1 { get; set; }
    public string? SayfaTitle2 { get; set; }
    public string? SayfaTitle3 { get; set; }
    public string? SayfaTitle4 { get; set; }
}
