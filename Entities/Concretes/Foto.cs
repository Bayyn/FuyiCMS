using System;
using Entities.Abstracts;

namespace Entities.Concretes;

public class Foto:IFoto
{
    public int FotoID { get; set; }
    public int FotoCatID { get; set; }
    public string? FotoAktif { get; set; }
    public string? FotoAna { get; set; }
    public string? FotoURL { get; set; }
    public int FotoSira { get; set; }
    public string? FotoName1 { get; set; }
    public string? FotoName2 { get; set; }
    public string? FotoName3 { get; set; }
    public string? FotoName4 { get; set; }
    public string? FotoOk1 { get; set; }
    public string? FotoOk2 { get; set; }
    public string? FotoOk3 { get; set; }
    public string? FotoOk4 { get; set; }
    public string? FotoLink1 { get; set; }
    public string? FotoLink2 { get; set; }
    public string? FotoLink3 { get; set; }
    public string? FotoLink4 { get; set; }
}

