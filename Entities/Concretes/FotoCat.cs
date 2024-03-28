using System;
using Entities.Abstracts;

namespace Entities.Concretes;

public class FotoCat:IFotoCat
{
    public int FotoCatID { get; set; }
    public string? FotoCatAktif { get; set; }
    public string? FotoCatTip { get; set; }
    public int FotoCatSira { get; set; }
    public int FotoCatFirmaID { get; set; }
    public string? FotoCatName1 { get; set; }
    public string? FotoCatName2 { get; set; }
    public string? FotoCatName3 { get; set; }
    public string? FotoCatName4 { get; set; }
}

