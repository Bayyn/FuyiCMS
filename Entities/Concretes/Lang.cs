using System;
using Entities.Abstracts;

namespace Entities.Concretes;

public class Lang:ILang
{
    public int LangID { get; set; }
    public string? LangName { get; set; }
    public string? LangCode { get; set; }
    public string? LangCode2 { get; set; }
    public string? LangAktif { get; set; }
    public int LangSira { get; set; }
}

