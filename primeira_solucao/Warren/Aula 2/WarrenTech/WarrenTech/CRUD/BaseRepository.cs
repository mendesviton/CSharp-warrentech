using Dia2.Classes;
using Dia2.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarrenTech.Classes;

namespace WarrenTech
{
    internal class BaseRepository<T> : IRepository<T> where T : BaseModel
    {

        List<T> pessoas;


        public  BaseRepository()
        {
                this.pessoas = new List<T>();
        }
        public virtual string Create(T p)
        {

            this.pessoas.Add(p);
            return $"O dado de Id: {p.id} foi salvo com sucesso!";
        }

        public virtual string Delete(int id)
        {
            this.pessoas.RemoveAt(id);
            return $"Pessoa física de id: {id} foi deletada com sucesso";
        }

        public virtual List<T> Read()
        {
            return pessoas;
        }

        public virtual string Update(T p)
        {
            return $"O dado de Id: {p.id} foi salvo com sucesso!";
        }
    }
}
