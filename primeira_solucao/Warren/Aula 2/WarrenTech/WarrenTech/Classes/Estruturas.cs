using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia2.Types
{
    internal class Estruturas
    {
        
        public  void Executa()
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.firstName = "Chimbinha";
            PessoaStruct pessoaStruct = new PessoaStruct();
            pessoaStruct.firstName = "Joelma"; 
            
            PessoaFisica pessoaFisica1 = new PessoaFisica();
            pessoaFisica1 = pessoaFisica;
            PessoaStruct pessoaStruct1 = new PessoaStruct();
            pessoaStruct1 = pessoaStruct;

            System.Console.WriteLine(pessoaStruct.firstName);
            System.Console.WriteLine(pessoaFisica.firstName);

            System.Console.WriteLine(pessoaStruct1.firstName);
            System.Console.WriteLine(pessoaFisica1.firstName);

            pessoaFisica.firstName = "fodase?";

            pessoaStruct.firstName = "fodasecaralho?";
            System.Console.WriteLine("valores alterados");
            System.Console.WriteLine(pessoaStruct.firstName);
            System.Console.WriteLine(pessoaFisica.firstName);

            System.Console.WriteLine(pessoaStruct1.firstName);
            System.Console.WriteLine(pessoaFisica1.firstName);




        }

       
    }
    struct PessoaStruct
    {
        public int secondName { get { return secondName; } set { this.secondName = value; } }

        public string firstName { get; set; }

        public int age { get; set; }
    }
    class PessoaFisica
    {

        public int secondName { get; set; }

        public string firstName { get; set; }

        public int age { get; set; }
    }
}
