using System;
namespace Entities.Concretes;

public class DB
{
    public required List<Agac> Agac { get; set; }
    public required List<Sayfa> Sayfa { get; set; }
    public required List<Foto> Foto { get; set; }
    public required List<FotoCat> FotoCat { get; set; }
    public required List<Lang> Lang { get; set; }
    public required List<Firma> Firma { get; set; }
}

