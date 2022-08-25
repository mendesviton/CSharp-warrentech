using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarrenTech.Classes;

namespace Dia2.Classes
{
    internal class PessoaFisica : Pessoa
    {
        public PessoaFisica(string fistname, string lastname,string cpf) : base(fistname, lastname)
        {
            this.cpf = cpf;
            this.firstName = fistname;
           this.lastName = lastname;
        }

        public string cpf { get; set; }

        override
        public string Saudacao()
        {
            return base.Saudacao() + " - " + this.cpf;

        }
        
    }
}
