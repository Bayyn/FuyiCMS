using System;
using DataAccess.Abstracts;
using Entities.Concretes;
using Newtonsoft.Json;

namespace DataAccess.Concretes
{
	public class AgacDal:IAgacDal
	{
        List<Agac> _Agacs = new();
        public AgacDal()
		{
            StreamReader r = new StreamReader("./Data/Database.json");
            DB db = JsonConvert.DeserializeObject<DB>(r.ReadToEnd())!;
            _Agacs = db.Agac;
        }

        public void Add(Agac Agac)
        { 
            _Agacs.Add(Agac);
        }

        public List<Agac> GetAll()
        {
            StreamReader r = new StreamReader("./Data/Database.json");
            DB db = JsonConvert.DeserializeObject<DB>(r.ReadToEnd())!;
            _Agacs = db.Agac;
            return _Agacs;
        }

    }
}

