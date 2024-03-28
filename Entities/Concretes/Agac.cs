using System;
using Entities.Abstracts;

namespace Entities.Concretes;

public class Agac:IAgac
{
    public int AgacID { get; set; }
    public int AgacUstID { get; set; }
    public string? AgacAktif { get; set; }
    public string? AgacPicUrl { get; set; }
    public int AgacFotoCat { get; set; }
    public int AgacFlashCat { get; set; }
    public int AgacFirmaID { get; set; }
    public int AgacSira { get; set; }
    public string? AgacPencere { get; set; }
    public string? AgacLink1 { get; set; }
    public string? AgacLink2 { get; set; }
    public string? AgacLink3 { get; set; }
    public string? AgacLink4 { get; set; }
   
    public string? AgacName1 { get; set; }
    public string? AgacName2 { get; set; }
    public string? AgacName3 { get; set; }
    public string? AgacName4 { get; set; }
    
    public string? AgacOzet1 { get; set; }
    public string? AgacOzet2 { get; set; }
    public string? AgacOzet3 { get; set; }
    public string? AgacOzet4 { get; set; }
    
    public string? AgacDetay1 { get; set; }
    public string? AgacDetay2 { get; set; }
    public string? AgacDetay3 { get; set; }
    public string? AgacDetay4 { get; set; }
    
    public string? AgacKeywords1 { get; set; }
    public string? AgacKeywords2 { get; set; }
    public string? AgacKeywords3 { get; set; }
    public string? AgacKeywords4 { get; set; }
    
    public string? AgacDescription1 { get; set; }
    public string? AgacDescription2 { get; set; }
    public string? AgacDescription3 { get; set; }
    public string? AgacDescription4 { get; set; }

    public string? AgacPermaLink1 { get; set; }
    public string? AgacPermaLink2 { get; set; }
    public string? AgacPermaLink3 { get; set; }
    public string? AgacPermaLink4 { get; set; }
    
    public string? AgacTitle1 { get; set; }
    public string? AgacTitle2 { get; set; }
    public string? AgacTitle3 { get; set; }
    public string? AgacTitle4 { get; set; }
    public string? AgacTip { get; set; }
}

