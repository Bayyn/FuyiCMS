﻿using System;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IAgacDal
{
    void Add(Agac Agac);
    List<Agac> GetAll();
}

