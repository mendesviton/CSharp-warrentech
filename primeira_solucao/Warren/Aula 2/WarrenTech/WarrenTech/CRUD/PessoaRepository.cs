using Dia2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrenTech.CRUD
{
    internal class PessoaRepository
    {
        public PessoaRepository()
        {
           this.peopleList = new List<PessoaFisica>();
        }
        public List<PessoaFisica> peopleList;
        public string Create(PessoaFisica pessoa)
        {
            this.peopleList.Add(pessoa);
            return "Pessoa "+pessoa.firstName + " Salva com sucesso";
        }

        public List<PessoaFisica> Read()
        {
            return peopleList;
        }
        public string Update(PessoaFisica pessoa)
        {
            return "Pessoa " + pessoa.firstName + " alterada com sucesso";
        }

        public string Delete(int id) { return "Pessoa id: " + id + " deletada com sucesso"; }
    }
}
