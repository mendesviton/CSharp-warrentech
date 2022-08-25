using Dia2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dia2.Types
{
    internal interface IRepository<T>
    {
       
        string Create(T p);

        List<T> Read();

        string Update(T p);

        string Delete(int id);
    }
}
