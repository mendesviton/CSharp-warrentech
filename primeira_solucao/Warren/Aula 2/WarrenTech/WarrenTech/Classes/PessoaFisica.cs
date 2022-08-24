using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia2.Classes
{
    internal class PessoaFisica : Pessoa
    {
        public PessoaFisica(string fistname, string lastname,string cpf) : base(fistname, lastname)
        {
            this.firstName = fistname;
           this.lastName = lastname;
        }

        public int cpf { get; set; }

        override
        public string Saudacao()
        {
            return base.Saudacao() + " - TELA FILHA PORRA";

        }
        
    }
}
