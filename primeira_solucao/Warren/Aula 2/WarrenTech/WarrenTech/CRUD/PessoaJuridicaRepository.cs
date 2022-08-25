using Dia2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarrenTech.Classes;

namespace WarrenTech.CRUD
{
    internal class PessoaJuridicaRepositorio : BaseRepository<PessoaJuridica>
    {
        public PessoaJuridicaRepositorio()
        {
           this.peopleList = new List<PessoaJuridica>();
        }
        public List<PessoaJuridica> peopleList;
        
        override
        public string Create(PessoaJuridica pessoa)
        {
            this.peopleList.Add(pessoa);
            return "Pessoa "+pessoa.firstName + " Salva com sucesso";
        }

        override
        public List<PessoaJuridica> Read()
        {
            return peopleList;
        }
        override
        public string Update(PessoaJuridica pessoa)
        {
            return "Pessoa " + pessoa.firstName + " alterada com sucesso";
        }

        override
        public string Delete(int id) { return "Pessoa id: " + id + " deletada com sucesso"; }
    }
}
