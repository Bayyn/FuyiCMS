using System;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IAgacService
{
    Agac Add(Agac Agac);
    List<Agac> GetAll();
}

