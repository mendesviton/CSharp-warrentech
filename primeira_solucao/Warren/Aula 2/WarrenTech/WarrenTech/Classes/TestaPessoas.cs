using Dia2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarrenTech.CRUD;

namespace WarrenTech.Classes
{
    internal class TestaPessoas
    {
        public void Executa() { 
             PessoaFisica ppl = new PessoaFisica(fistname: "Vitor",lastname:"Daniel sdasd ",cpf: "1231232");
            PessoaFisica ppl1 = new PessoaFisica(fistname: "Vitor Daniel", lastname: "Daniel ", cpf: "1231232");
            

            System.Console.WriteLine(ppl.Saudacao());
            


            PessoaRepository crud = new PessoaRepository();

            System.Console.WriteLine(crud.Create(ppl));
            System.Console.WriteLine(crud.Create(ppl1));
            System.Console.WriteLine(crud.Update(ppl));

            /*for (int i = 0; i < crud.Read().Count; i++)
            {
                System.Console.WriteLine(crud.peopleList[i].firstName);   
            }*/
            foreach (var item in crud.Read())
            {
                System.Console.WriteLine(item.Saudacao());
                
            }


            System.Console.WriteLine(crud.Delete(1));
        }
        public void ExecutaJuridico()
        {
            PessoaJuridica pplj = new PessoaJuridica(fistname: "Vitor Daniel juridico", lastname: "Daniel ", CNPJ: "12312313");
            System.Console.WriteLine(pplj.Saudacao());

            PessoaJuridicaRepositorio crud = new PessoaJuridicaRepositorio();

            System.Console.WriteLine(crud.Create(pplj));
            System.Console.WriteLine(crud.Update(pplj));

            foreach (var item in crud.Read())
            {
                System.Console.WriteLine(item.Saudacao());

            }


            System.Console.WriteLine(crud.Delete(1));

        }
    }
}
