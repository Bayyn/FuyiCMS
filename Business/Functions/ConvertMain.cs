using System;
using Business.Dtos;
using Entities.Concretes;

namespace Business.Functions;

public class ConvertMain
{
    public List<AgacMain> ConvertAgac(List<Agac> agacs, int langid = 1)
    {
        List<AgacMain> _agacs = new();

        agacs.ForEach(x => {
            AgacMain newitem = new();

            newitem.AgacID = x.AgacID;
            newitem.AgacUstID = x.AgacUstID;
            newitem.AgacAktif = x.AgacAktif;
            newitem.AgacPicUrl = x.AgacPicUrl;
            newitem.AgacFotoCat = x.AgacFotoCat;
            newitem.AgacFlashCat = x.AgacFlashCat;
            newitem.AgacFirmaID = x.AgacFirmaID;
            newitem.AgacSira = x.AgacSira;
            newitem.AgacPencere = x.AgacPencere;
            newitem.AgacLink = (string)typeof(Agac).GetProperty("AgacLink" + langid)!.GetValue(x)!;
            newitem.AgacName = (string)typeof(Agac).GetProperty("AgacName" + langid)!.GetValue(x)!;
            newitem.AgacOzet = (string)typeof(Agac).GetProperty("AgacOzet" + langid)!.GetValue(x)!;
            newitem.AgacDetay = (string)typeof(Agac).GetProperty("AgacDetay" + langid)!.GetValue(x)!;
            newitem.AgacKeywords = (string)typeof(Agac).GetProperty("AgacKeywords" + langid)!.GetValue(x)!;
            newitem.AgacDescription = (string)typeof(Agac).GetProperty("AgacDescription" + langid)!.GetValue(x)!;
            newitem.AgacPermaLink = (string)typeof(Agac).GetProperty("AgacPermaLink" + langid)!.GetValue(x)!;
            newitem.AgacTitle = (string)typeof(Agac).GetProperty("AgacTitle" + langid)!.GetValue(x)!;
            newitem.AgacTip = x.AgacTip;
            _agacs.Add(newitem);

        });

        return _agacs;
    }
}

