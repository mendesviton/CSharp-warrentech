﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dia2.Types
{
    internal interface IRepository
    {
        string Create(Pessoa p);

        List<Pessoa> Read();

        string Update(Pessoa p);

        string Delete(int id);
    }
}
