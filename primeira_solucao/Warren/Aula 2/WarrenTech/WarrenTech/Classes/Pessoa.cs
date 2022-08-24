using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia2.Classes
{
    internal class Pessoa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Pessoa(string fistname, string lastname)
        {
            this.lastName = lastName;
            this.firstName = fistname;   
        }
        virtual
        public  string Saudacao() { return(" Olá " + this.firstName+ " "+ this.lastName); }
    }
}
