using System;
using Business.Dtos;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IAgacService
{
    Agac Add(Agac Agac);
    List<AgacMain> GetAll(int langid);
}

