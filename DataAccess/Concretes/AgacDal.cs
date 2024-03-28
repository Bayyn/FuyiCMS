using System;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
	public class AgacDal:IAgacDal
	{
        List<Agac> _Agacs = new();
        public AgacDal()
		{
            Agac newAgac = new();

            newAgac.AgacID = 1;
            newAgac.AgacName1 = "Test";
            _Agacs.Add(newAgac);
		}

        public void Add(Agac Agac)
        {
            _Agacs.Add(Agac);
        }

        public List<Agac> GetAll()
        {
            return _Agacs;
        }
    }
}

