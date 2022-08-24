using Dia2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrenTech.Classes
{
    internal class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string fistname, string lastname,string CNPJ) : base(fistname, lastname)
        {
            this.cnpj = CNPJ;
        }

        public string cnpj { get; set; }
        public override string Saudacao()
        {
            return base.Saudacao() + " - " + this.cnpj;
        }
    }
}
