using System;
using Business.Abstracts;
using Business.Dtos;
using Business.Functions;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class AgacManager : IAgacService
{
    private readonly IAgacDal _AgacDal;
    public AgacManager(IAgacDal AgacDal)
    {
        _AgacDal = AgacDal;
    }
    public Agac Add(Agac Agac)
    {
        //business rules

        _AgacDal.Add(Agac);

        return Agac;
    }

    public List<AgacMain> GetAll(int langid)
    {
        ConvertMain convertMain = new ConvertMain();
        List<AgacMain> Agacs = convertMain.ConvertAgac(_AgacDal.GetAll(), langid);
        return Agacs;
    }
}

