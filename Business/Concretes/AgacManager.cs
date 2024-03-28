using System;
using Business.Abstracts;
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

    public List<Agac> GetAll()
    {
        List<Agac> Agacs = _AgacDal.GetAll();

        return Agacs;
    }
}

