using Dia2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrenTech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica ppl = new PessoaFisica(fistname: "Vitor",lastname:"Daniel sdasd ",cpf: "1231232");

            
            System.Console.WriteLine(ppl.Saudacao());
        }
    }
}
