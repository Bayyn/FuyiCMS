using System;
using Entities.Abstracts;

namespace Entities.Concretes;

public class Firma:IFirma
{
    public int FirmaID { get; set; }
    public string? FirmaName { get; set; }
    public string? FirmaLogo { get; set; }
    public string? FirmaCode { get; set; }
    public string? FirmaAktif { get; set; }
    public string? FirmaMenu { get; set; }
    public int FirmaSira { get; set; }
    public string? FirmaTitle1 { get; set; }
    public string? FirmaTitle2 { get; set; }
    public string? FirmaTitle3 { get; set; }
    public string? FirmaTitle4 { get; set; }
    public string? FirmaKeywords1 { get; set; }
    public string? FirmaKeywords2 { get; set; }
    public string? FirmaKeywords3 { get; set; }
    public string? FirmaKeywords4 { get; set; }
    public string? FirmaDescription1 { get; set; }
    public string? FirmaDescription2 { get; set; }
    public string? FirmaDescription3 { get; set; }
    public string? FirmaDescription4 { get; set; }
    public string? FirmaIletisimNumara { get; set; }
    public string? FirmaIletisimMail { get; set; }
    public string? FirmaAdres { get; set; }
    public string? FirmaMap { get; set; }
    public string? FirmaPicUrl { get; set; }
}

